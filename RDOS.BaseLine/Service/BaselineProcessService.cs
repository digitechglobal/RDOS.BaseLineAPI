using AutoMapper;
using Dapper;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers.Dapper;
using nProx.Helpers.Services.Repository;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using RestSharp.Authenticators;
using RestSharp;
using static RDOS.BaseLine.Models.Results;
using RDOS.BaseLine.Models.Result;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace RDOS.BaseLine.Service
{
    public class BaselineProcessService : IBaselineProcessService
    {
        private readonly ILogger<BaselineProcessService> _logger;
        private readonly IBaseRepository<BlBlsettingInformation> _blSettingInfoRepo;
        private readonly IBaseRepository<BlBlsettingProcess> _blSettingProcessRepo;
        private readonly IBaseRepository<BlBlsettingTransactionStatus> _blSettingTransactionStatusRepo;
        private readonly IBaseRepository<BlBlsettingProcessPending> _blSettingProcessPendingRepo;
        private readonly IBaseRepository<BlBlsettingEmail> _blSettingEmailRepo;
        private readonly IBaseRepository<BlBlprocess> _blProcessRepo;
        private readonly IBaseRepository<BlRawPo> _blRawPo;
        private readonly IBaseRepository<BlRawSo> _blRawSo;
        private readonly IBaseRepository<BlIssueQty> _blIssueQty;
        private readonly IBaseRepository<BlReceiptQty> _blReceiptyQty;
        private readonly IBaseRepository<BlCloseStock> _blCloseQty;
        private readonly IBaseRepository<SaleCalendar> _salesCalendarRepo;
        private readonly IBaseRepository<SaleCalendarHoliday> _holidayRepo;
        private readonly IBaseRepository<PoRpoparameter> _rpoParameterRepo;
        private readonly IBaseRepository<BlRunningSale> _runningSalesRepo;
        private readonly IMapper _mapper;
        private readonly IDapperRepositories _dapper;

        public BaselineProcessService(
            ILogger<BaselineProcessService> logger, 
            IBaseRepository<BlBlsettingInformation> blSettingInfoRepo, 
            IBaseRepository<BlBlsettingProcess> blSettingProcessRepo, 
            IBaseRepository<BlBlsettingTransactionStatus> blSettingTransactionStatusRepo, 
            IBaseRepository<BlBlsettingProcessPending> blSettingProcessPendingRepo, 
            IBaseRepository<BlBlsettingEmail> blSettingEmailRepo, 
            IBaseRepository<BlBlprocess> blProcessRepo,
            IBaseRepository<BlRawPo> blRawPo,
            IBaseRepository<BlIssueQty> blIssuseQty,
            IBaseRepository<BlReceiptQty> blReceiptyQty,
            IBaseRepository<BlCloseStock> blCloseQty,
            IBaseRepository<BlRawSo> blRawSo,
            IBaseRepository<SaleCalendar> salesCalendarRepo,
            IBaseRepository<SaleCalendarHoliday> holidayRepo,
            IBaseRepository<PoRpoparameter> rpoParameterRepo,
            IBaseRepository<BlRunningSale> runningSalesRepo,
            IMapper mapper,
            IDapperRepositories dapper)
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
            _blIssueQty = blIssuseQty;
            _blReceiptyQty = blReceiptyQty;
            _blCloseQty = blCloseQty;
            _blRawSo = blRawSo;
            _salesCalendarRepo = salesCalendarRepo;
            _holidayRepo = holidayRepo;
            _rpoParameterRepo = rpoParameterRepo;
            _runningSalesRepo = runningSalesRepo;
        }

        public async Task<BaseResultModel> ProcessPO(string baselineDate, string settingRef, string userName)
        {
            try
            {
                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                // Function query
                var query = @"SELECT * FROM collectrawpo(@baselinedate, @username, @settingref)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", baselineDate);
                parameters.Add("@username", userName);
                parameters.Add("@settingref", settingRef);

                // Excute query
                var listData = ((List<BlRawPo>)_dapper.QueryWithParams<BlRawPo>(query, parameters));

                // List record po by baseline date
                var listRawPo = _blRawPo.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawPo != null && listRawPo.Count > 0)
                {
                    _blRawPo.DeleteMany(listRawPo);
                } 

                // Insert to database
                _blRawPo.InsertMany(listData);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> ProcessInvIssue(string baselineDate, string settingRef, string userName, string typeData)
        {
            try
            {
                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                List<BlIssueQty> listDataFinal = new List<BlIssueQty>();
                // Function query
                var query = @"SELECT * FROM collectissueadjustment(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", baselineDate);
                parameters.Add("@username", userName);
                parameters.Add("@settingref", settingRef);
                parameters.Add("@typedata", typeData);

                // Excute query
                var listData = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query, parameters));
                listDataFinal.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectissueinv(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", baselineDate);
                parameters2.Add("@username", userName);
                parameters2.Add("@settingref", settingRef);
                parameters2.Add("@typedata", typeData);

                // Excute query
                var listData2 = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query2, parameters2));

                listDataFinal.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectissuetransfer(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", baselineDate);
                parameters3.Add("@username", userName);
                parameters3.Add("@settingref", settingRef);
                parameters3.Add("@typedata", typeData);

                // Excute query
                var listData3 = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query3, parameters3));

                listDataFinal.AddRange(listData3);

                // List record po by baseline date
                var listRawIssuse = _blIssueQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawIssuse != null && listRawIssuse.Count > 0)
                {
                    _blIssueQty.DeleteMany(listRawIssuse);
                }

                // Insert to database
                _blIssueQty.InsertMany(listDataFinal);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> ProcessInvReceipt(string baselineDate, string settingRef, string userName, string typeData)
        {
            try
            {
                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                List<BlReceiptQty> listDataFinal = new List<BlReceiptQty>();
                // Function query
                var query = @"SELECT * FROM collectreceiptadjustment(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", baselineDate);
                parameters.Add("@username", userName);
                parameters.Add("@settingref", settingRef);
                parameters.Add("@typedata", typeData);

                // Excute query
                var listData = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query, parameters));
                listDataFinal.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectreceiptinv(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", baselineDate);
                parameters2.Add("@username", userName);
                parameters2.Add("@settingref", settingRef);
                parameters2.Add("@typedata", typeData);

                // Excute query
                var listData2 = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query2, parameters2));

                listDataFinal.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectreceipttransfer(@baselinedate, @username, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", baselineDate);
                parameters3.Add("@username", userName);
                parameters3.Add("@settingref", settingRef);
                parameters3.Add("@typedata", typeData);

                // Excute query
                var listData3 = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query3, parameters3));

                listDataFinal.AddRange(listData3);

                // List record po by baseline date
                var listRawIssuse = _blReceiptyQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawIssuse != null && listRawIssuse.Count > 0)
                {
                    _blReceiptyQty.DeleteMany(listRawIssuse);
                }

                // Insert to database
                _blReceiptyQty.InsertMany(listDataFinal);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> ProcessInvCloseQty(string baselineDate, string settingRef, string userName)
        {
            try
            {
                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                List<BlCloseStock> listDataConcat = new List<BlCloseStock>();
                // Function query
                var query = @"SELECT * FROM collectcloseinv(@baselinedate, @username, @settingref)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", baselineDate);
                parameters.Add("@username", userName);
                parameters.Add("@settingref", settingRef);

                // Excute query
                var listData = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query, parameters));
                listDataConcat.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectcloseadjustment(@baselinedate, @username, @settingref)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", baselineDate);
                parameters2.Add("@username", userName);
                parameters2.Add("@settingref", settingRef);

                // Excute query
                var listData2 = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query2, parameters2));
                listDataConcat.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectclosetransfer(@baselinedate, @username, @settingref)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", baselineDate);
                parameters3.Add("@username", userName);
                parameters3.Add("@settingref", settingRef);

                // Excute query
                var listData3 = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query3, parameters3));
                listDataConcat.AddRange(listData3);

                List<BlCloseStock> listDataFinal = new List<BlCloseStock>();

                // Handle group item
                var dataTransactionGroup = listDataConcat.GroupBy(x => new { x.ItemId, x.DistributorId, x.WareHouseId, x.LocationId }).Select(x => x.First()).ToList();
                foreach (var itemInv in dataTransactionGroup)
                {
                    var listInvGroup = listDataConcat.Where(x => x.ItemId == itemInv.ItemId &&
                                                      x.DistributorId == itemInv.DistributorId &&
                                                      x.WareHouseId == itemInv.WareHouseId &&
                                                      x.LocationId == itemInv.LocationId).OrderByDescending(x => x.UpdatedDate).ToList();

                    listDataFinal.Add(listInvGroup.First());
                }


                // List record po by baseline date
                var listRawCloseQty = _blCloseQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawCloseQty != null && listRawCloseQty.Count > 0)
                {
                    _blCloseQty.DeleteMany(listRawCloseQty);
                }

                // Insert to database
                _blCloseQty.InsertMany(listDataFinal);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> ProcessSO(string baselineDate, string settingRef, string userName)
        {
            try
            {
                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == baselineDateNew.Year);
                if (salesCalendar == null)
                {
                    return new BaseResultModel 
                    { 
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found sales calendar"
                    };
                }

                // Handle holiday
                var listHoliday = _holidayRepo.Find(x => x.SaleCalendarId == salesCalendar.Id).ToList();

                var workingday = "true";

                if (salesCalendar.IncludeWeekend == CalendarConstant.SAT && 
                    baselineDateNew.DayOfWeek.ToString() == CalendarConstant.Sunday)
                {
                    workingday = "false";
                }

                if (string.IsNullOrEmpty(salesCalendar.IncludeWeekend) && 
                    (baselineDateNew.DayOfWeek.ToString() == CalendarConstant.Saturday || 
                    baselineDateNew.DayOfWeek.ToString() == CalendarConstant.Sunday))
                {
                    workingday = "false";
                }

                if (listHoliday.Any(x => x.HolidayDate.Date == baselineDateNew.Date))
                {
                    workingday = "false";
                }

                // Function query
                var query = @"SELECT * FROM collectrawso(@baselinedate, @username, @settingref, @workingday)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", baselineDate);
                parameters.Add("@username", userName);
                parameters.Add("@settingref", settingRef);
                parameters.Add("@workingday", workingday);

                // Excute query
                var listData = ((List<BlRawSo>)_dapper.QueryWithParams<BlRawSo>(query, parameters));

                // List record so by baseline date
                var listRawSo = _blRawSo.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawSo != null && listRawSo.Count > 0)
                {
                    _blRawSo.DeleteMany(listRawSo);
                }

                // Insert to database
                _blRawSo.InsertMany(listData);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> ProcessRunningSales(string baselineDate, string userName)
        {
            try
            {
                // Check runnig sales week from RPO
                var rpoParameter = _rpoParameterRepo.FirstOrDefault(x => x != null);
                if (rpoParameter == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found rpo parameter"
                    };
                }

                int? runningRate = rpoParameter.SellOutRunningRate;

                DateTime baselineDateNew = DateTime.Parse(baselineDate);
                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == baselineDateNew.Year);
                if (salesCalendar == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found sales calendar"
                    };
                }

                // Handle holiday
                var listHoliday = _holidayRepo.Find(x => x.SaleCalendarId == salesCalendar.Id).ToList();

                int x = 5;

                if (salesCalendar.IncludeWeekend == CalendarConstant.SAT)
                {
                    x += 1;
                }

                if (salesCalendar.IncludeWeekend == CalendarConstant.SUN)
                {
                    x += 2;
                }

                int xFinal = x * (runningRate != null ? runningRate.Value : 0);

                if (xFinal == 0)
                {
                    return new BaseResultModel
                    {
                        Code = 404,
                        IsSuccess = false,
                        Message = "Cannot found day number"
                    };
                }

                List<DateTime> listDateFinal = new List<DateTime>();

                DateTime EndDate = baselineDateNew.AddDays(-(xFinal-1));
                for (var dateCurrent = baselineDateNew.Date; dateCurrent >= baselineDateNew.AddDays(-(xFinal - 1)); dateCurrent = dateCurrent.AddDays(-1))
                {
                    if (x == 6 && dateCurrent.DayOfWeek.ToString() == CalendarConstant.Sunday)
                    {
                        xFinal += 1;
                        continue;
                    }

                    if (x == 5 && 
                       (dateCurrent.DayOfWeek.ToString() == CalendarConstant.Saturday ||
                       dateCurrent.DayOfWeek.ToString() == CalendarConstant.Sunday))
                    {
                        xFinal += 1;
                        continue;
                    }

                    if (listHoliday.Any(x => x.HolidayDate.Date == baselineDateNew.Date))
                    {
                        xFinal -= 1;
                        continue;
                    }

                    listDateFinal.Add(dateCurrent);
                }

                int xFinalV2 = listDateFinal.Count();

                List<BlRunningSale> listDataFinal = new List<BlRunningSale>();
                foreach (var dateCollect in listDateFinal)
                {
                    var dateCollectFinal = dateCollect.ToString("yyyy-MM-dd");

                    // Function query
                    var query = @"SELECT * FROM collectrunningsales(@baselinedate, @username)";

                    // Handle parameter
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@baselinedate", dateCollectFinal);
                    parameters.Add("@username", userName);

                    // Excute query
                    var listData = ((List<BlRunningSale>)_dapper.QueryWithParams<BlRunningSale>(query, parameters));
                    if (listData != null && listData.Count > 0)
                    {
                        listDataFinal.AddRange(listData);
                    }
                    else
                    {
                        xFinalV2 -= 1;
                        continue;
                    }
                }

                var dataFinalGroup = listDataFinal.GroupBy(x => new { x.ItemId, x.DistributorId, x.DistributorShiptoId }).Select(x => x.First()).ToList();


                foreach (var itemInsert in dataFinalGroup)
                {
                    var listDataGroup = listDataFinal.Where(x => x.ItemId == itemInsert.ItemId &&
                                                           x.DistributorId == itemInsert.DistributorId &&
                                                           x.DistributorShiptoId == itemInsert.DistributorShiptoId).ToList();
                    int _runningSalesByBaseQty = 0;
                    int _runningSalesBySalesQty = 0;
                    int _runningSalesPurchaseQty = 0;
                    foreach (var item in listDataGroup)
                    {
                        _runningSalesByBaseQty += item.RunningSalesByBaseQty != null ? item.RunningSalesByBaseQty.Value : 0;
                        _runningSalesBySalesQty += item.RunningSalesBySalesQty != null ? item.RunningSalesBySalesQty.Value : 0;
                        _runningSalesPurchaseQty += item.RunningSalesByPurchaseQty != null ? item.RunningSalesByPurchaseQty.Value : 0;
                    }

                    itemInsert.RunningSalesByBaseQty = _runningSalesByBaseQty / xFinalV2;
                    itemInsert.RunningSalesBySalesQty = _runningSalesBySalesQty / xFinalV2;
                    itemInsert.RunningSalesByPurchaseQty = _runningSalesPurchaseQty / xFinalV2;
                }


                // List record runningsales by baseline date
                var listRawRunningSales = _runningSalesRepo.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                // Remove record by baseline date
                if (listRawRunningSales != null && listRawRunningSales.Count > 0)
                {
                    _runningSalesRepo.DeleteMany(listRawRunningSales);
                }

                // Insert to database
                _runningSalesRepo.InsertMany(dataFinalGroup);

                return new BaseResultModel
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "N"
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }
    }
}
