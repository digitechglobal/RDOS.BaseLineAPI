using AutoMapper;
using Dapper;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers.Dapper;
using nProx.Helpers.Services.Repository;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service
{
    public class BaselineSettingService : IBaselineSettingService
    {
        public IScheduler Scheduler { get; set; }
        private readonly ILogger<BaselineSettingService> _logger;
        private readonly IBaseRepository<BlBlsettingInformation> _blSettingInfoRepo;
        private readonly IBaseRepository<BlBlsettingProcess> _blSettingProcessRepo;
        private readonly IBaseRepository<BlBlsettingTransactionStatus> _blSettingTransactionStatusRepo;
        private readonly IBaseRepository<BlBlsettingProcessPending> _blSettingProcessPendingRepo;
        private readonly IBaseRepository<BlBlsettingEmail> _blSettingEmailRepo;
        private readonly IBaseRepository<BlBlprocess> _blProcessRepo;
        private readonly IBaseRepository<BlRawPo> _blRawPo;
        private readonly IMapper _mapper;
        private readonly IDapperRepositories _dapper;
        private readonly ISchedulerFactory _schedulerFactory;

        public BaselineSettingService(
            ILogger<BaselineSettingService> logger,
            IBaseRepository<BlBlsettingInformation> blSettingInfoRepo,
            IBaseRepository<BlBlsettingProcess> blSettingProcessRepo,
            IBaseRepository<BlBlsettingTransactionStatus> blSettingTransactionStatusRepo,
            IBaseRepository<BlBlsettingProcessPending> blSettingProcessPendingRepo,
            IBaseRepository<BlBlsettingEmail> blSettingEmailRepo,
            IBaseRepository<BlBlprocess> blProcessRepo,
            IBaseRepository<BlRawPo> blRawPo,
            IMapper mapper,
            IDapperRepositories dapper,
            ISchedulerFactory schedulerFactory)
        {
            _logger = logger;
            _blSettingInfoRepo = blSettingInfoRepo;
            _blSettingProcessRepo = blSettingProcessRepo;
            _blSettingTransactionStatusRepo = blSettingTransactionStatusRepo;
            _blSettingProcessPendingRepo = blSettingProcessPendingRepo;
            _blSettingEmailRepo = blSettingEmailRepo;
            _blProcessRepo = blProcessRepo;
            _mapper = mapper;
            _dapper = dapper;
            _blRawPo = blRawPo;
            _schedulerFactory = schedulerFactory;
        }

        public async Task<BaseResultModel> ChangeSetting(BaselineSettingModel dataInput, string userLogin)
        {
            try
            {
                // Gen setting ref
                var settingRefNew = await GenRefNumber();

                // Validate process code
                var resultValidate = await CheckProcessInDb(dataInput.BaseLineProcesses);
                if (!resultValidate.IsSuccess) return resultValidate;

                // Map data baseline setting
                var createBaselineSetting = _mapper.Map<BlBlsettingInformation>(dataInput);
                createBaselineSetting.SettingRef = settingRefNew;
                createBaselineSetting.CreatedDate = DateTime.Now;
                createBaselineSetting.CreatedBy = userLogin;
                createBaselineSetting.Id = Guid.NewGuid();

                // Map list setting process pending
                var listProcessPendingNew = _mapper.Map<List<BlBlsettingProcessPending>>(dataInput.ProcessPendings);

                foreach (var processPendingNew in listProcessPendingNew)
                {
                    processPendingNew.Id = Guid.NewGuid();
                    processPendingNew.CreatedBy = userLogin;
                    processPendingNew.CreatedDate = DateTime.Now;
                    processPendingNew.BaselineSettingRef = settingRefNew;
                }
                _blSettingProcessPendingRepo.InsertMany(listProcessPendingNew);

                // Map list setting process
                var listSettingProcessNew = _mapper.Map<List<BlBlsettingProcess>>(dataInput.BaseLineProcesses);

                foreach (var processNew in listSettingProcessNew)
                {
                    processNew.Id = Guid.NewGuid();
                    processNew.CreatedBy = userLogin;
                    processNew.CreatedDate = DateTime.Now;
                    processNew.BaselineSettingRef = settingRefNew;
                }
                _blSettingProcessRepo.InsertMany(listSettingProcessNew);

                // Handle setting email
                if (dataInput.BaselineSettingEmail != null)
                {
                    var settingEmailNew = _mapper.Map<BlBlsettingEmail>(dataInput.BaselineSettingEmail);
                    settingEmailNew.Id = Guid.NewGuid();
                    settingEmailNew.CreatedBy = userLogin;
                    settingEmailNew.CreatedDate = DateTime.Now;
                    settingEmailNew.BaselineSettingRef = settingRefNew;
                    _blSettingEmailRepo.Insert(settingEmailNew);
                }
                _blSettingInfoRepo.Insert(createBaselineSetting);
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 201,
                    Message = "Create successfully",
                    Data = (await GetCurrentBaselineSetting()).Data
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> CheckProcessInDb(List<BaseLineProcessModel> listProcess)
        {
            try
            {
                foreach (var item in listProcess)
                {
                    var itemExist = _blProcessRepo.FirstOrDefault(x => x.ProcessCode == item.ProcessCode);

                    if (itemExist == null)
                    {
                        return new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 404,
                            Message = $"Cannot found process {item.ProcessCode}"
                        };
                    }
                }

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<string> GenRefNumber()
        {
            var listData = _blSettingInfoRepo.Find(x => !x.IsDeleted).ToList();
            return GenRefNumber(listData.Count, listData);
            string GenRefNumber(int number, List<BlBlsettingInformation> listData)
            {
                var refNew = PrefixRefBaselinesSetting.PREFIX_REF + number;
                var checkExist = listData.FirstOrDefault(x => x.SettingRef == refNew);
                if (checkExist != null)
                {
                    number++;
                    return GenRefNumber(number, listData);
                }
                else
                {
                    return refNew;
                }
            }
        }

        public async Task<BaseResultModel> GetListSettingTransactionStatus()
        {
            try
            {
                var listData = _blSettingTransactionStatusRepo.GetAll();
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Get list successfully",
                    Data = listData
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> GetListProcess()
        {
            try
            {
                var listData = _blProcessRepo.GetAll();
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully",
                    Data = listData
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> GetDetailBaselineSetting(string settingRef)
        {
            try
            {
                var settingInfo = _blSettingInfoRepo.FirstOrDefault(x => !x.IsDeleted && x.SettingRef == settingRef);
                if (settingInfo == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = $"Cannot found baseline setting {settingRef}"
                    };
                }
                var listTransactionStatus = _blSettingTransactionStatusRepo.Find(x => x != null).ToList();
                var listProcessPending = _blSettingProcessPendingRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingRef).ToList();
                var listProcess = _blSettingProcessRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingRef).OrderBy(x => x.Priority).ToList();
                var listProcessNew = _mapper.Map<List<BlBlsettingProcessDetail>>(listProcess);
                foreach (var item in listProcessNew)
                {
                    var process = _blProcessRepo.FirstOrDefault(x => x.ProcessCode == item.ProcessCode);
                    item.Process = process;
                }
                var settingEmail = _blSettingEmailRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingRef).FirstOrDefault();

                var dataResponse = new BaselineSettingDetailModel();
                dataResponse.BlBlsettingInformation = settingInfo;
                dataResponse.ProcessPendings = listProcessPending;
                dataResponse.BaseLineProcesses = listProcessNew;
                dataResponse.BaselineSettingEmail = settingEmail;

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully",
                    Data = dataResponse
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<ResultModelWithObject<BaselineSettingDetailModel>> GetCurrentBaselineSetting()
        {
            try
            {
                var settingInfo = _blSettingInfoRepo.Find(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
                if (settingInfo == null)
                {
                    return new ResultModelWithObject<BaselineSettingDetailModel>
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = $"Cannot found baseline setting"
                    };
                }
                var listTransactionStatus = _blSettingTransactionStatusRepo.Find(x => x != null).ToList();
                var listProcessPending = _blSettingProcessPendingRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingInfo.SettingRef).ToList();
                var listProcess = _blSettingProcessRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingInfo.SettingRef).OrderBy(x => x.Priority).ToList();
                var listProcessNew = _mapper.Map<List<BlBlsettingProcessDetail>>(listProcess);
                foreach (var item in listProcessNew)
                {
                    var process = _blProcessRepo.FirstOrDefault(x => x.ProcessCode == item.ProcessCode);
                    item.Process = process;
                }
                var settingEmail = _blSettingEmailRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingInfo.SettingRef).FirstOrDefault();

                var dataResponse = new BaselineSettingDetailModel();
                dataResponse.BlBlsettingInformation = settingInfo;
                dataResponse.ProcessPendings = listProcessPending;
                dataResponse.BaseLineProcesses = listProcessNew;
                dataResponse.BaselineSettingEmail = settingEmail;
                
                return new ResultModelWithObject<BaselineSettingDetailModel>
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully",
                    Data = dataResponse
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new ResultModelWithObject<BaselineSettingDetailModel>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<ResultModelWithObject<ListBaselineSetting>> SearchBaselineSetting(BaselineSearch parameters)
        {
            try
            {
                var res = _blSettingInfoRepo.Find(x => !x.IsDeleted);

                if (!string.IsNullOrWhiteSpace(parameters.SearchValue))
                {
                    res = res.Where(x =>
                    (!string.IsNullOrWhiteSpace(x.SettingRef) && x.SettingRef.ToLower().Contains(parameters.SearchValue.ToLower())) ||
                    (!string.IsNullOrWhiteSpace(x.Description) && x.Description.ToLower().Contains(parameters.SearchValue.ToLower()))).ToList();
                }

                if (parameters.FromDate.HasValue)
                {
                    res = res.Where(x => x.CreatedDate.Date >= parameters.FromDate.Value.Date);
                }

                if (parameters.ToDate.HasValue)
                {
                    res = res.Where(x => x.CreatedDate.Date <= parameters.ToDate.Value.Date.AddDays(1).AddTicks(-1));
                }

                res = res.ToList();
                var items = _mapper.Map<List<BlBlsettingInformation>>(res);

                if (parameters.IsDropdown)
                {
                    var reponse = new ListBaselineSetting { Items = items };

                    return new ResultModelWithObject<ListBaselineSetting>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = reponse
                    };
                }
                else
                {
                    var baselineTempPagged = PagedList<BlBlsettingInformation>.ToPagedList(items, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
                    var repsonse = new ListBaselineSetting { Items = baselineTempPagged, MetaData = baselineTempPagged.MetaData };

                    //return metadata
                    return new ResultModelWithObject<ListBaselineSetting>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = repsonse
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new ResultModelWithObject<ListBaselineSetting>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }
    }
}
