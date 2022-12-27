using AutoMapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
        private readonly IBaseRepository<BlConfirmPerformanceRawSo> _blConfirmPerformanceRawSoRepo;

        public ConfirmPerformanceService(
            ILogger<ConfirmPerformanceService> logger,
            IBaseRepository<BlRawSo> blRawSo,
            IMapper mapper,
            IDapperRepositories dapper,
            IBaseRepository<BlConfirmPerformance> blConfirmPerformanceRepo,
            IBaseRepository<BlConfirmPerformanceDetail> blConfirmPerformanceDetailRepo,
            IBaseRepository<BlConfirmPerformanceRawSo> blConfirmPerformanceRawSoRepo)
        {
            _logger = logger;
            _mapper = mapper;
            _dapper = dapper;
            _blRawSo = blRawSo;
            _blConfirmPerformanceRepo = blConfirmPerformanceRepo;
            _blConfirmPerformanceDetailRepo = blConfirmPerformanceDetailRepo;
            _blConfirmPerformanceRawSoRepo = blConfirmPerformanceRawSoRepo;
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

                res = res.OrderByDescending(x => x.CreatedDate).ToList();
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
                var res = _blRawSo.Find(x => !x.IsDeleted && !(bool)x.RecordPerformance).Select(x => new RawSoModel()
                {
                    Id = x.Id,
                    TransactionDate = x.TransactionDate,
                    OrderRefNumber = x.OrderRefNumber,
                    Status = x.Status,
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    CustomerShiptoId = x.CustomerShiptoId,
                    CustomerShiptoName = x.CustomerShiptoName,
                    Dsaid = x.Dsaid,
                    Dsadesc = x.Dsadesc,
                    RouteZoneId = x.RouteZoneId,
                    RouteZoneDesc = x.RouteZoneDesc,
                    BranchId = x.BranchId,
                    BranchName = x.BranchName,
                    RegionId = x.RegionId,
                    RegionName = x.RegionName,
                    SubRegionId = x.SubRegionId,
                    SubRegionName = x.SubRegionName,
                    AreaId = x.AreaId,
                    AreaName = x.AreaName,
                    SubAreaId = x.SubAreaId,
                    SubAreaName = x.SubAreaName,
                    SalesOrgId = x.SalesOrgId,
                    BaselineDate = x.BaselineDate
                });

                if (!string.IsNullOrWhiteSpace(parameters.SalesOrgCode) && 
                    !string.IsNullOrWhiteSpace(parameters.Type) &&
                    parameters.ValueCode.Count > 0)
                {
                    if (parameters.Type.ToLower() == ConfirmPerformanceType.BRANCH.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && parameters.ValueCode.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.REGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && parameters.ValueCode.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.SUBREGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && parameters.ValueCode.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.AREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && parameters.ValueCode.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.SUBAREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && parameters.ValueCode.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.DSA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && parameters.ValueCode.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Type.ToLower() == ConfirmPerformanceType.ROUTEZONE.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && parameters.ValueCode.Contains(x.RouteZoneId)) &&
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
                var items = _mapper.Map<List<RawSoModel>>(res);

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
                    var baselineTempPagged = PagedList<RawSoModel>.ToPagedList(items, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
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

        public async Task<BaseResultModel> ValidateCommon(ConfirmPerformanceModel dataInput)
        {
            try
            {
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

                if (dataInput.FromDate.Date > dataInput.ToDate.Date)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "To date must be greater than from date"
                    };
                }

                if (dataInput.IsConfirm && dataInput.RawSoIds.Count == 0)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "RawSoIds is not null"
                    };
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
        public async Task<BaseResultModel> CreateConfirmPerformance(ConfirmPerformanceModel dataInput, string userLogin)
        {
            try
            {
                // Gen setting ref
                var confirmRefNew = await GenRefNumber();

                // Validate data
                var resultValidate = await ValidateCommon(dataInput);
                if (!resultValidate.IsSuccess) return resultValidate;

                // Map data
                var createConfirmPer = _mapper.Map<BlConfirmPerformance>(dataInput);

                if (dataInput.IsConfirm)
                {
                    createConfirmPer.ConfirmDate = DateTime.Now;
                    createConfirmPer.ConfirmByUser = userLogin;
                }

                createConfirmPer.ConfirmRef = confirmRefNew;
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

                var listRawSoInsert = new List<BlConfirmPerformanceRawSo>();

                foreach (var rawSo in dataInput.RawSoIds)
                {
                    var confirmPerRawSo = new BlConfirmPerformanceRawSo();
                    confirmPerRawSo.Id = Guid.NewGuid();
                    confirmPerRawSo.RowSoId = rawSo;
                    confirmPerRawSo.ConfirmRef = confirmRefNew;
                    confirmPerRawSo.CreatedBy = userLogin;
                    confirmPerRawSo.CreatedDate = DateTime.Today;
                    listRawSoInsert.Add(confirmPerRawSo);
                }

                _blConfirmPerformanceRawSoRepo.InsertMany(listRawSoInsert);

                if (dataInput.IsConfirm)
                {
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
                }


                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 201,
                    Message = "Created Successfully",
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

        public async Task<BaseResultModel> UpdateConfirmPerformance(ConfirmPerformanceModel dataInput, string userLogin)
        {
            try
            {
                var dataInDb = _blConfirmPerformanceRepo.FirstOrDefault(x => x.Id == dataInput.Id && !(bool)x.IsDeleted);

                if (dataInDb == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found confirm performance"
                    };
                }

                var listDataInDb = _blConfirmPerformanceDetailRepo.Find(x => x.ConfirmRef == dataInDb.ConfirmRef && !(bool)x.IsDeleted).ToList();

                foreach (var validateItem in dataInput.ConfirmPerformanceDetails.Where(x => x.Id != null && x.Id != Guid.Empty))
                {
                    if (!listDataInDb.Any(x => x.Id == validateItem.Id))
                    {
                        return new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 404,
                            Message = "Cannot found confirm performance detail"
                        };
                    }
                }

                // Validate data
                var resultValidate = await ValidateCommon(dataInput);
                if (!resultValidate.IsSuccess) return resultValidate;

                // Map data
                var updateConfirmPer = _mapper.Map(dataInput, dataInDb);

                if (dataInput.IsConfirm)
                {
                    updateConfirmPer.ConfirmByUser = userLogin;
                    updateConfirmPer.ConfirmDate = DateTime.Now;
                }

                updateConfirmPer.UpdatedDate = DateTime.Today;
                updateConfirmPer.UpdatedBy = userLogin;

                _blConfirmPerformanceRepo.Update(updateConfirmPer);

                // Delete detail
                foreach (var itemInDb in listDataInDb)
                {
                    if (dataInput.ConfirmPerformanceDetails.Count == 0 || !dataInput.ConfirmPerformanceDetails.Any(x => x.Id == itemInDb.Id))
                    {
                        itemInDb.IsDeleted = true;
                        itemInDb.UpdatedDate = DateTime.Now;
                        itemInDb.UpdatedBy = userLogin;
                        _blConfirmPerformanceDetailRepo.Update(itemInDb);
                    }
                }

                // Update detail
                foreach (var itemUpdateNew in dataInput.ConfirmPerformanceDetails.Where(x => x.Id != null && x.Id != Guid.Empty))
                {
                    var itemDetailExist = listDataInDb.FirstOrDefault(x => x.Id == itemUpdateNew.Id);
                    var itemUpdate = _mapper.Map(itemUpdateNew, itemDetailExist);
                    itemUpdate.UpdatedDate = DateTime.Now;
                    itemUpdate.UpdatedBy = userLogin;
                    _blConfirmPerformanceDetailRepo.Update(itemUpdate);
                }

                // Map data detail
                var listDataDetail = _mapper.Map<List<BlConfirmPerformanceDetail>>(dataInput.ConfirmPerformanceDetails.Where(x => x.Id == null || x.Id == Guid.Empty));

                foreach (var itemDetail in listDataDetail)
                {
                    itemDetail.Id = Guid.NewGuid();
                    itemDetail.CreatedBy = userLogin;
                    itemDetail.CreatedDate = DateTime.Today;
                    itemDetail.ConfirmRef = dataInDb.ConfirmRef;
                    itemDetail.IsDeleted = false;
                }

                _blConfirmPerformanceDetailRepo.InsertMany(listDataDetail);

                // Handle raw so
                // Delete
                var listDataRawSoInDb = _blConfirmPerformanceRawSoRepo.Find(x => x.ConfirmRef == dataInDb.ConfirmRef).ToList();
                if (listDataRawSoInDb.Count > 0)
                {
                    _blConfirmPerformanceRawSoRepo.DeleteMany(listDataRawSoInDb);
                }

                // Insert
                var listRawSoInsert = new List<BlConfirmPerformanceRawSo>();

                foreach (var rawSo in dataInput.RawSoIds)
                {
                    var confirmPerRawSo = new BlConfirmPerformanceRawSo();
                    confirmPerRawSo.Id = Guid.NewGuid();
                    confirmPerRawSo.RowSoId = rawSo;
                    confirmPerRawSo.ConfirmRef = dataInDb.ConfirmRef;
                    confirmPerRawSo.CreatedBy = userLogin;
                    confirmPerRawSo.CreatedDate = DateTime.Today;
                    listRawSoInsert.Add(confirmPerRawSo);
                }

                _blConfirmPerformanceRawSoRepo.InsertMany(listRawSoInsert);


                if (dataInput.IsConfirm)
                {
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
                }
                

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Updated Successfully",
                    Data = (await GetDetailConfirmPerformance(dataInDb.ConfirmRef)).Data
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

        public async Task<BaseResultModel> DeleteConfirmPerformance(string confirmRef, string userLogin)
        {
            try
            {
                var dataInDb = _blConfirmPerformanceRepo.FirstOrDefault(x => x.ConfirmRef == confirmRef && !(bool)x.IsDeleted);

                if (dataInDb == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found confirm performance"
                    };
                }

                if (dataInDb.ConfirmDate.HasValue)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "Cannot delete confirm performance"
                    };
                }

                dataInDb.IsDeleted = true;
                dataInDb.UpdatedDate = DateTime.Now;
                dataInDb.UpdatedBy = userLogin;

                _blConfirmPerformanceRepo.Update(dataInDb);

                // Detail
                var listDataInDb = _blConfirmPerformanceDetailRepo.Find(x => x.ConfirmRef == dataInDb.ConfirmRef && !(bool)x.IsDeleted).ToList();

                // Delete detail
                foreach (var itemInDb in listDataInDb)
                {
                    itemInDb.IsDeleted = true;
                    itemInDb.UpdatedDate = DateTime.Now;
                    itemInDb.UpdatedBy = userLogin;
                    _blConfirmPerformanceDetailRepo.Update(itemInDb);
                }

                // Raw so
                var listDataRawSoInDb = _blConfirmPerformanceRawSoRepo.Find(x => x.ConfirmRef == dataInDb.ConfirmRef).ToList();
                _blConfirmPerformanceRawSoRepo.DeleteMany(listDataRawSoInDb);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Deleted Successfully",
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
                var dataInDb = _blConfirmPerformanceRepo.FirstOrDefault(x => x.ConfirmRef == confirmRef && !(bool)x.IsDeleted);
                if (dataInDb == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found"
                    };
                }

                var listDataDetail = _blConfirmPerformanceDetailRepo.Find(x => x.ConfirmRef == confirmRef && !(bool)x.IsDeleted).ToList();
                var listDataRawSoDetail = _blConfirmPerformanceRawSoRepo.Find(x => x.ConfirmRef == confirmRef).Select(x => x.RowSoId).ToList();


                var resRawSos = _blRawSo.Find(x => !x.IsDeleted && listDataRawSoDetail.Contains(x.Id)).Select(x => new RawSoModel()
                {
                    Id = x.Id,
                    TransactionDate = x.TransactionDate,
                    OrderRefNumber = x.OrderRefNumber,
                    Status = x.Status,
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    CustomerShiptoId = x.CustomerShiptoId,
                    CustomerShiptoName = x.CustomerShiptoName,
                    Dsaid = x.Dsaid,
                    Dsadesc = x.Dsadesc,
                    RouteZoneId = x.RouteZoneId,
                    RouteZoneDesc = x.RouteZoneDesc,
                    BranchId = x.BranchId,
                    BranchName = x.BranchName,
                    RegionId = x.RegionId,
                    RegionName = x.RegionName,
                    SubRegionId = x.SubRegionId,
                    SubRegionName = x.SubRegionName,
                    AreaId = x.AreaId,
                    AreaName = x.AreaName,
                    SubAreaId = x.SubAreaId,
                    SubAreaName = x.SubAreaName,
                    SalesOrgId = x.SalesOrgId,
                    BaselineDate = x.BaselineDate
                }).ToList();
                

                var dataRes = new ConfirmPerDetailModel();
                dataRes.ConfirmPerformance = dataInDb;
                dataRes.ConfirmPerformanceDetails = listDataDetail;
                dataRes.ListRowSo = resRawSos;
                

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
