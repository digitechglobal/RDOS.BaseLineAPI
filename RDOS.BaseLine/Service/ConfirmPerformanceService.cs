using AutoMapper;
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
    public class ConfirmPerformanceService : IConfirmPerformanceService
    {
        public IScheduler Scheduler { get; set; }
        private readonly ILogger<ConfirmPerformanceService> _logger;
        private readonly IBaseRepository<BlRawSo> _blRawSo;
        private readonly IMapper _mapper;
        private readonly IDapperRepositories _dapper;
        private readonly IBaseRepository<BlConfirmPerformance> _blConfirmPerformanceRepo;
        private readonly IBaseRepository<BlConfirmPerformanceDetail> _blConfirmPerformanceDetailRepo;

        public ConfirmPerformanceService(
            ILogger<ConfirmPerformanceService> logger,
            IBaseRepository<BlRawSo> blRawSo,
            IMapper mapper,
            IDapperRepositories dapper,
            IBaseRepository<BlConfirmPerformance> blConfirmPerformanceRepo,
            IBaseRepository<BlConfirmPerformanceDetail> blConfirmPerformanceDetailRepo)
        {
            _logger = logger;
            _mapper = mapper;
            _dapper = dapper;
            _blRawSo = blRawSo;
            _blConfirmPerformanceRepo = blConfirmPerformanceRepo;
            _blConfirmPerformanceDetailRepo = blConfirmPerformanceDetailRepo;
        }

        private async Task<string> GenRefNumber()
        {
            var listData = _blConfirmPerformanceRepo.GetAll();
            return GenRefNumber(listData.Count(), listData);
            string GenRefNumber(int number, IEnumerable<BlConfirmPerformance> listData)
            {
                var refNew = PrefixRef.PREFIX_CONFIRM + number;
                var checkExist = listData.FirstOrDefault(x => x.ConfirmRef == refNew);
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

        public async Task<ResultModelWithObject<ListonfirmPerforamce>> SearchConfirmPer(ConfirmPerforamceSearch parameters)
        {
            try
            {
                var res = _blConfirmPerformanceRepo.Find(x => (bool)!x.IsDeleted);

                if (!string.IsNullOrWhiteSpace(parameters.SearchValue))
                {
                    res = res.Where(x =>
                    (!string.IsNullOrWhiteSpace(x.ConfirmRef) && x.ConfirmRef.ToLower().Contains(parameters.SearchValue.ToLower())) ||
                    (!string.IsNullOrWhiteSpace(x.Description) && x.Description.ToLower().Contains(parameters.SearchValue.ToLower()))).ToList();
                }

                if (parameters.FromDate.HasValue)
                {
                    res = res.Where(x => x.CreatedDate.Value.Date >= parameters.FromDate.Value.Date);
                }

                if (parameters.ToDate.HasValue)
                {
                    res = res.Where(x => x.CreatedDate.Value.Date <= parameters.ToDate.Value.Date.AddDays(1).AddTicks(-1));
                }

                res = res.ToList();
                var items = _mapper.Map<List<BlConfirmPerformance>>(res);

                if (parameters.IsDropdown)
                {
                    var reponse = new ListonfirmPerforamce { Items = items };

                    return new ResultModelWithObject<ListonfirmPerforamce>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = reponse
                    };
                }
                else
                {
                    var baselineTempPagged = PagedList<BlConfirmPerformance>.ToPagedList(items, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
                    var repsonse = new ListonfirmPerforamce { Items = baselineTempPagged, MetaData = baselineTempPagged.MetaData };

                    //return metadata
                    return new ResultModelWithObject<ListonfirmPerforamce>
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
                return new ResultModelWithObject<ListonfirmPerforamce>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<ResultModelWithObject<ListRawSoNotPerformance>> GetListRowSONotPerformance(FilterConfirmPer parameters)
        {
            try
            {
                var res = _blRawSo.Find(x => !x.IsDeleted && !(bool)x.RecordPerformance);

                if (!string.IsNullOrWhiteSpace(parameters.SalesOrgCode) && 
                    !string.IsNullOrWhiteSpace(parameters.Type) &&
                    !string.IsNullOrWhiteSpace(parameters.ValueCode))
                {
                    if (parameters.Type.ToLower() == ConfirmPerformanceType.BRANCH.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && x.BranchId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.REGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && x.RegionId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.SUBREGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && x.SubRegionId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.AREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && x.AreaId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.SUBAREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && x.SubAreaId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.DSA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && x.Dsaid == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.ROUTEZONE.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && x.RouteZoneId == parameters.ValueCode) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return new ResultModelWithObject<ListRawSoNotPerformance>
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        };
                    }
                }

                if (parameters.FromDate.HasValue)
                {
                    res = res.Where(x => x.BaselineDate.Date >= parameters.FromDate.Value.Date);
                }

                if (parameters.ToDate.HasValue)
                {
                    res = res.Where(x => x.BaselineDate.Date <= parameters.ToDate.Value.Date.AddDays(1).AddTicks(-1));
                }

                res = res.ToList();
                var items = _mapper.Map<List<BlRawSo>>(res);

                if (parameters.IsDropdown)
                {
                    var reponse = new ListRawSoNotPerformance { Items = items };

                    return new ResultModelWithObject<ListRawSoNotPerformance>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = reponse
                    };
                }
                else
                {
                    var baselineTempPagged = PagedList<BlRawSo>.ToPagedList(items, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
                    var repsonse = new ListRawSoNotPerformance { Items = baselineTempPagged, MetaData = baselineTempPagged.MetaData };

                    //return metadata
                    return new ResultModelWithObject<ListRawSoNotPerformance>
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
                return new ResultModelWithObject<ListRawSoNotPerformance>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> CreateConfirmPerformance(ConfirmPerformanceModel dataInput, string userLogin)
        {
            try
            {
                // Gen setting ref
                var confirmRefNew = await GenRefNumber();

                if (dataInput.Type.ToLower() != ConfirmPerformanceType.BRANCH.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.REGION.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.SUBREGION.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.AREA.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.SUBAREA.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.ROUTEZONE.ToLower() &&
                    dataInput.Type.ToLower() != ConfirmPerformanceType.DSA.ToLower())
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "Type is incorrect"
                    };
                }

                if (dataInput.RawSoIds.Count == 0)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "RawSoIds is not null"
                    };
                }

                foreach (var item in dataInput.RawSoIds)
                {
                    var rawSoInDb = _blRawSo.Find(x => x.Id == item).FirstOrDefault();
                    if (rawSoInDb != null)
                    {
                        rawSoInDb.RecordPerformance = true;
                        rawSoInDb.WorkingDay = true;
                        rawSoInDb.RecordPerformanceUpdateBy = userLogin;
                        rawSoInDb.RecordPerformanceUpdateDateTime = DateTime.Today;
                        _blRawSo.Update(rawSoInDb);
                    }
                }

                // Map data
                var createConfirmPer = _mapper.Map<BlConfirmPerformance>(dataInput);
                createConfirmPer.ConfirmRef = confirmRefNew;
                createConfirmPer.ConfirmByUser = userLogin;
                createConfirmPer.CreatedDate = DateTime.Today;
                createConfirmPer.CreatedBy = userLogin;
                createConfirmPer.Id = Guid.NewGuid();
                createConfirmPer.IsDeleted = false;

                _blConfirmPerformanceRepo.Insert(createConfirmPer);

                // Map data detail
                var listDataDetail = _mapper.Map<List<BlConfirmPerformanceDetail>>(dataInput.ConfirmPerformanceDetails);

                foreach (var itemDetail in listDataDetail)
                {
                    itemDetail.Id = Guid.NewGuid();
                    itemDetail.CreatedBy = userLogin;
                    itemDetail.CreatedDate = DateTime.Today;
                    itemDetail.ConfirmRef = confirmRefNew;
                    itemDetail.IsDeleted = false;
                }

                _blConfirmPerformanceDetailRepo.InsertMany(listDataDetail);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 201,
                    Message = "Confirm Successfully",
                    Data = (await GetDetailConfirmPerformance(confirmRefNew)).Data
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

        public async Task<BaseResultModel> GetDetailConfirmPerformance(string confirmRef)
        {
            try
            {
                var dataInDb = _blConfirmPerformanceRepo.FirstOrDefault(x => x.ConfirmRef == confirmRef);
                if (dataInDb == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found"
                    };
                }

                var listDataDetail = _blConfirmPerformanceDetailRepo.Find(x => x.ConfirmRef == confirmRef).ToList();

                var dataRes = new ConfirmPerDetailModel();
                dataRes.ConfirmPerformance = dataInDb;
                dataRes.ConfirmPerformanceDetails = listDataDetail;
                

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully",
                    Data = dataRes
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
    }
}
