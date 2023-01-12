using AutoMapper;
using Dapper;
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
using SysAdmin.Models.StaticValue;
using Newtonsoft.Json;
using static RDOS.BaseLine.Constants.Constants;

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
        private readonly IBaseRepository<PoStockKeepingDay> _poStockKeepingDayRepo;
        private readonly IBaseRepository<PoStockKeepingDayItemHierarchy> _poStockKeepingDayItemRepo;
        private readonly IBaseRepository<ItemHierarchyMapping> _itemHierarchyMappingRepo;
        private readonly IBaseRepository<BlSafetyStockAssessment> _blSafetyStockAssessmentRepo;
        private readonly IBaseRepository<BlCustomerPerformanceDaily> _blCusPerDailyRepo;
        private readonly IBaseRepository<BlCurrentCustomerPerformanceDaily> _blCurrentCusPerDailyRepo;
        private readonly IBaseRepository<BlSalesIndicator> _blSalesIndicatorRepo;
        private readonly IBaseRepository<SaleCalendarGenerate> _saleCalendarGenerateRepo;
        private readonly IBaseRepository<BlCusPerDailySkubuyedDetail> _blCusPerDailySkubuyedDetailRepo;
        private readonly IBaseRepository<BlCurrentCusPerDailySkubuyedDetail> _blCurrentCusPerDailySkubuyedDetailRepo;
        private readonly IBaseRepository<VisitList> _visitListRepo;
        private readonly IBaseRepository<BlAuditLog> _blAuditLogRepo;
        private readonly IBaseRepository<BlNormOfBussinessModel> _blNormOfBussinessModelRepo;
        private readonly IBaseRepository<BlOutletAccumulate> _blOutletAccumulateRepo;
        private readonly IBaseRepository<BlHistory> _blHistoryRepo;
        private readonly IMapper _mapper;
        private readonly IDapperRepositories _dapper;
        public IRestClient _client;
        private string _username;

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
            IBaseRepository<PoStockKeepingDay> poStockKeepingDayRepo,
            IBaseRepository<PoStockKeepingDayItemHierarchy> poStockKeepingDayItemRepo,
            IBaseRepository<ItemHierarchyMapping> itemHierarchyMappingRepo,
            IBaseRepository<BlSafetyStockAssessment> blSafetyStockAssessmentRepo,
            IBaseRepository<BlCustomerPerformanceDaily> blCusPerDailyRepo,
            IBaseRepository<BlCurrentCustomerPerformanceDaily> blCurrentCusPerDailyRepo,
            IBaseRepository<BlCusPerDailySkubuyedDetail> blCusPerDailySkubuyedDetailRepo,
            IBaseRepository<BlCurrentCusPerDailySkubuyedDetail> blCurrentCusPerDailySkubuyedDetailRepo,
            IBaseRepository<BlSalesIndicator> blSalesIndicatorRepo,
            IBaseRepository<SaleCalendarGenerate> saleCalendarGenerateRepo,
            IBaseRepository<VisitList> visitListRepo,
            IMapper mapper,
            IDapperRepositories dapper,
            IBaseRepository<BlAuditLog> blAuditLogRepo,
            IBaseRepository<BlNormOfBussinessModel> blNormOfBussinessModelRepo,
            IBaseRepository<BlOutletAccumulate> blOutletAccumulateRepo,
            IBaseRepository<BlHistory> blHistoryRepo)
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
            _poStockKeepingDayRepo = poStockKeepingDayRepo;
            _poStockKeepingDayItemRepo = poStockKeepingDayItemRepo;
            _itemHierarchyMappingRepo = itemHierarchyMappingRepo;
            _blSafetyStockAssessmentRepo = blSafetyStockAssessmentRepo;
            _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == CommonData.SystemUrlCode.KpiCode).Select(x => x.Url).FirstOrDefault());
            _blCurrentCusPerDailyRepo = blCurrentCusPerDailyRepo;
            _blCusPerDailyRepo = blCusPerDailyRepo;
            _blSalesIndicatorRepo = blSalesIndicatorRepo;
            _saleCalendarGenerateRepo = saleCalendarGenerateRepo;
            _blCusPerDailySkubuyedDetailRepo = blCusPerDailySkubuyedDetailRepo;
            _visitListRepo = visitListRepo;
            _blNormOfBussinessModelRepo = blNormOfBussinessModelRepo;
            _blAuditLogRepo = blAuditLogRepo;
            _blCurrentCusPerDailySkubuyedDetailRepo = blCurrentCusPerDailySkubuyedDetailRepo;
            _blOutletAccumulateRepo = blOutletAccumulateRepo;
            _blHistoryRepo = blHistoryRepo;
        }

        public async Task<BaseResultModel> ProcessPO(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                // Function query
                var query = @"SELECT * FROM collectrawpo(@baselinedate, @settingref)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);
                parameters.Add("@settingref", dataRequest.SettingRef);

                // Excute query
                var listData = ((List<BlRawPo>)_dapper.QueryWithParams<BlRawPo>(query, parameters));

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    // List record po by baseline date
                    var listRawPo = _blRawPo.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                    // Remove record by baseline date
                    if (listRawPo != null && listRawPo.Count > 0)
                    {
                        _blRawPo.DeleteMany(listRawPo);
                    }

                    // Insert to database
                    _blRawPo.InsertMany(listData);
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.POPROCESS, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.POPROCESS, dataRequest.HistoryRefNumber);
                    }

                    // List record po by baseline date
                    var listRawPo = _blRawPo.Find(x => x.BaselineDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawPo = listRawPo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.POPROCESS, dataRequest.HistoryRefNumber);
                    }

                    var itemRemoves = listRawPo.ToList();

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count() > 0)
                    {
                        _blRawPo.DeleteMany(itemRemoves);
                    }

                    if (listData.Count > 0)
                    {
                        // Insert to database
                        _blRawPo.InsertMany(listData);
                    }
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.POPROCESS, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.POPROCESS, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessInvIssue(ProcessRequest dataRequest, string typeData)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                List<BlIssueQty> listDataFinal = new List<BlIssueQty>();
                // Function query
                var query = @"SELECT * FROM collectissueadjustment(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);
                parameters.Add("@settingref", dataRequest.SettingRef);
                parameters.Add("@typedata", typeData);

                // Excute query
                var listData = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query, parameters));
                listDataFinal.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectissueinv(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", dataRequest.BaselineDate);
                parameters2.Add("@settingref", dataRequest.SettingRef);
                parameters2.Add("@typedata", typeData);

                // Excute query
                var listData2 = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query2, parameters2));

                listDataFinal.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectissuetransfer(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", dataRequest.BaselineDate);
                parameters3.Add("@settingref", dataRequest.SettingRef);
                parameters3.Add("@typedata", typeData);

                // Excute query
                var listData3 = ((List<BlIssueQty>)_dapper.QueryWithParams<BlIssueQty>(query3, parameters3));

                listDataFinal.AddRange(listData3);

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    // List record po by baseline date
                    var listRawIssuse = _blIssueQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                    // Remove record by baseline date
                    if (listRawIssuse != null && listRawIssuse.Count > 0)
                    {
                        _blIssueQty.DeleteMany(listRawIssuse);
                    }

                    // Insert to database
                    _blIssueQty.InsertMany(listDataFinal);

                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_ISSUE, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_ISSUE, dataRequest.HistoryRefNumber);
                    }

                    // List record by baseline date
                    var listRawIssueQty = _blIssueQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawIssueQty = listRawIssueQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_ISSUE, dataRequest.HistoryRefNumber);
                    }

                    listRawIssueQty = listRawIssueQty.ToList();
                    var itemRemoves = _mapper.Map<List<BlIssueQty>>(listRawIssueQty);

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count() > 0)
                    {
                        _blIssueQty.DeleteMany(itemRemoves);
                    }

                    if (listDataFinal.Count > 0)
                    {
                        // Insert to database
                        _blIssueQty.InsertMany(listDataFinal);
                    }
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_ISSUE, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_ISSUE, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessInvReceipt(ProcessRequest dataRequest, string typeData)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                List<BlReceiptQty> listDataFinal = new List<BlReceiptQty>();
                // Function query
                var query = @"SELECT * FROM collectreceiptadjustment(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);
                parameters.Add("@settingref", dataRequest.SettingRef);
                parameters.Add("@typedata", typeData);

                // Excute query
                var listData = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query, parameters));
                listDataFinal.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectreceiptinv(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", dataRequest.BaselineDate);
                parameters2.Add("@settingref", dataRequest.SettingRef);
                parameters2.Add("@typedata", typeData);

                // Excute query
                var listData2 = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query2, parameters2));

                listDataFinal.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectreceipttransfer(@baselinedate, @settingref, @typedata)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", dataRequest.BaselineDate);
                parameters3.Add("@settingref", dataRequest.SettingRef);
                parameters3.Add("@typedata", typeData);

                // Excute query
                var listData3 = ((List<BlReceiptQty>)_dapper.QueryWithParams<BlReceiptQty>(query3, parameters3));

                listDataFinal.AddRange(listData3);

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    // List record po by baseline date
                    var listRawIssuse = _blReceiptyQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                    // Remove record by baseline date
                    if (listRawIssuse != null && listRawIssuse.Count > 0)
                    {
                        _blReceiptyQty.DeleteMany(listRawIssuse);
                    }

                    // Insert to database
                    _blReceiptyQty.InsertMany(listDataFinal);
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                    }

                    // List record by baseline date
                    var listRawReceiptQty = _blReceiptyQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawReceiptQty = listRawReceiptQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                    }

                    listRawReceiptQty = listRawReceiptQty.ToList();
                    var itemRemoves = _mapper.Map<List<BlReceiptQty>>(listRawReceiptQty);

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count() > 0)
                    {
                        _blReceiptyQty.DeleteMany(itemRemoves);
                    }

                    if (listDataFinal.Count > 0)
                    {
                        // Insert to database
                        _blReceiptyQty.InsertMany(listDataFinal);
                    }
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessInvCloseQty(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                List<BlCloseStock> listDataConcat = new List<BlCloseStock>();
                // Function query
                var query = @"SELECT * FROM collectcloseinv(@baselinedate, @settingref)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);
                parameters.Add("@settingref", dataRequest.SettingRef);

                // Excute query
                var listData = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query, parameters));
                listDataConcat.AddRange(listData);

                // Function query 2
                var query2 = @"SELECT * FROM collectcloseadjustment(@baselinedate, @settingref)";

                // Handle parameter
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("@baselinedate", dataRequest.BaselineDate);
                parameters2.Add("@settingref", dataRequest.SettingRef);

                // Excute query
                var listData2 = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query2, parameters2));
                listDataConcat.AddRange(listData2);

                // Function query 3
                var query3 = @"SELECT * FROM collectclosetransfer(@baselinedate, @settingref)";

                // Handle parameter
                DynamicParameters parameters3 = new DynamicParameters();
                parameters3.Add("@baselinedate", dataRequest.BaselineDate);
                parameters3.Add("@settingref", dataRequest.SettingRef);

                // Excute query
                var listData3 = ((List<BlCloseStock>)_dapper.QueryWithParams<BlCloseStock>(query3, parameters3));
                listDataConcat.AddRange(listData3);

                // Get baseline date previous
                var baselineDatePrevious = _blCloseQty.Find(x => x.BaselineDate.Date < baselineDateNew.Date).OrderByDescending(x => x.BaselineDate.Date).FirstOrDefault();

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    // Get list item in close qty of baseline date previous
                    if (baselineDatePrevious != null)
                    {
                        var listDataInDb = _blCloseQty.Find(x => x.BaselineDate.Date == baselineDatePrevious.BaselineDate.Date).ToList();
                        var dataInDbMaps = _mapper.Map<List<BlCloseStock>>(listDataInDb);
                        listDataConcat.AddRange(dataInDbMaps);
                    }

                    List<BlCloseStock> listDataFinal = new List<BlCloseStock>();

                    // Handle group item
                    var dataTransactionGroup = listDataConcat.GroupBy(x => new { x.ItemId, x.DistributorId, x.WareHouseId, x.LocationId }).Select(x => x.First()).ToList();
                    foreach (var itemInv in dataTransactionGroup)
                    {
                        var listInvGroup = listDataConcat.Where(x => x.ItemId == itemInv.ItemId &&
                                                          x.DistributorId == itemInv.DistributorId &&
                                                          x.WareHouseId == itemInv.WareHouseId &&
                                                          x.LocationId == itemInv.LocationId).OrderByDescending(x => x.UpdatedDate).ToList();
                        var dataCloseInsertNew = listInvGroup.First();
                        dataCloseInsertNew.BaselineDate = baselineDateNew;
                        listDataFinal.Add(dataCloseInsertNew);
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
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.BL_CLOSE_QTY, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listDataConcat = listDataConcat.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.BL_CLOSE_QTY, dataRequest.HistoryRefNumber);
                    }

                    // Get list item in close qty of baseline date previous
                    if (baselineDatePrevious != null)
                    {
                        var listDataInDb = _blCloseQty.Find(x => x.BaselineDate.Date == baselineDatePrevious.BaselineDate.Date).ToList();
                        var dataInDbMaps = _mapper.Map<List<BlCloseStock>>(listDataInDb);
                        listDataConcat.AddRange(dataInDbMaps);
                    }

                    List<BlCloseStock> listDataFinal = new List<BlCloseStock>();

                    // Handle group item
                    var dataTransactionGroup = listDataConcat.GroupBy(x => new { x.ItemId, x.DistributorId, x.WareHouseId, x.LocationId }).Select(x => x.First()).ToList();
                    foreach (var itemInv in dataTransactionGroup)
                    {
                        var listInvGroup = listDataConcat.Where(x => x.ItemId == itemInv.ItemId &&
                                                          x.DistributorId == itemInv.DistributorId &&
                                                          x.WareHouseId == itemInv.WareHouseId &&
                                                          x.LocationId == itemInv.LocationId).OrderByDescending(x => x.UpdatedDate).ToList();
                        var dataCloseInsertNew = listInvGroup.First();
                        dataCloseInsertNew.BaselineDate = baselineDateNew;
                        listDataFinal.Add(dataCloseInsertNew);
                    }


                    // List record po by baseline date
                    var listRawCloseQty = _blCloseQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawCloseQty = listRawCloseQty.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode) &&
                        (!x.IsPrevious)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                    }

                    listRawCloseQty = listRawCloseQty.ToList();
                    List<BlCloseStock> itemRemoves = listRawCloseQty.ToList();

                    var itemPreviousRemoves = _blCloseQty.Find(x => x.BaselineDate.Date == baselineDateNew.Date && x.IsPrevious).ToList();
                    itemRemoves.AddRange(itemPreviousRemoves);

                    // Remove record by baseline date
                    if (listRawCloseQty != null && listRawCloseQty.Count() > 0)
                    {
                        _blCloseQty.DeleteMany(itemRemoves);
                    }

                    // Insert to database
                    _blCloseQty.InsertMany(listDataFinal);
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.BL_CLOSE_QTY, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.BL_CLOSE_QTY, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessSO(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == baselineDateNew.Year);
                if (salesCalendar == null)
                {
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found sales calendar"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);

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
                var query = @"SELECT * FROM collectrawso(@baselinedate, @settingref, @workingday)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);
                parameters.Add("@settingref", dataRequest.SettingRef);
                parameters.Add("@workingday", workingday);

                // Excute query
                var listData = ((List<BlRawSo>)_dapper.QueryWithParams<BlRawSo>(query, parameters));

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    // List record so by baseline date
                    var listRawSo = _blRawSo.Find(x => x.BaselineDate.Date == baselineDateNew.Date).ToList();

                    // Remove record by baseline date
                    if (listRawSo != null && listRawSo.Count > 0)
                    {
                        _blRawSo.DeleteMany(listRawSo);
                    }

                    // Insert to database
                    _blRawSo.InsertMany(listData);
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);
                    }

                    // List record so by baseline date
                    var listRawSo = _blRawSo.Find(x => x.BaselineDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawSo = listRawSo.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);
                    }

                    var itemRemoves = listRawSo.ToList();

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count > 0)
                    {
                        _blRawSo.DeleteMany(itemRemoves);
                    }

                    // Insert to database
                    _blRawSo.InsertMany(listData);
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.SOPROCESS, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessRunningSales(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                // Check runnig sales week from RPO
                var rpoParameter = _rpoParameterRepo.FirstOrDefault(x => x != null);
                if (rpoParameter == null)
                {
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found rpo parameter"
                    }, baselineDateNew, null, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);

                }

                int? runningRate = rpoParameter.SellOutRunningRate;

                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == baselineDateNew.Year);
                if (salesCalendar == null)
                {
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found sales calendar"
                    }, baselineDateNew, null, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
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
                    return await CreateAuditLog(new BaseResultModel
                    {
                        Code = 404,
                        IsSuccess = false,
                        Message = "Cannot found day number"
                    }, baselineDateNew, null, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
                }

                List<DateTime> listDateFinal = new List<DateTime>();

                DateTime EndDate = baselineDateNew.AddDays(-(xFinal - 1));
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
                    var query = @"SELECT * FROM collectrunningsales(@baselinedate)";

                    // Handle parameter
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@baselinedate", dateCollectFinal);

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

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
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

                    return await CreateAuditLog(new BaseResultModel
                    {
                        Code = 200,
                        IsSuccess = true,
                        Message = "Successfully"
                    }, baselineDateNew, null, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listDataFinal = listDataFinal.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
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

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawRunningSales = listRawRunningSales.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
                    }

                    listRawRunningSales = listRawRunningSales.ToList();
                    var itemRemoves = listRawRunningSales.ToList();

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count() > 0)
                    {
                        _runningSalesRepo.DeleteMany(itemRemoves);
                    }

                    if (dataFinalGroup.Count > 0)
                    {
                        // Insert to database
                        _runningSalesRepo.InsertMany(dataFinalGroup);
                    }
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Successfully"
                    }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, null, BlProcessConst.AVERATE_DAILY_RUNNING_SALE, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessSafetyStockAssessment(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                // Function query
                var query = @"SELECT * FROM collectsafetystock(@baselinedate)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);

                // Excute query
                var listData = ((List<BlSafetyStockAssessment>)_dapper.QueryWithParams<BlSafetyStockAssessment>(query, parameters));

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    foreach (var data in listData)
                    {
                        Boolean isCheck = false;
                        DateTime currentDate = DateTime.Today;
                        var stockeepingDayInDb = new PoStockKeepingDay();

                        // SubArea
                        if (data.SubAreaId != null)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.SubAreaId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Area
                        if (data.AreaId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.AreaId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // SubRegion
                        if (data.SubRegionId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.SubRegionId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Region
                        if (data.RegionId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.RegionId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Branch
                        if (data.BranchId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.BranchId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        int stockKeepingDayNumber = 0;

                        if (isCheck)
                        {
                            var itemHierachyInDb = _itemHierarchyMappingRepo.FirstOrDefault(x => x.Id == data.Hierarchy);
                            if (itemHierachyInDb == null)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = 404,
                                    IsSuccess = false,
                                    Message = "Cannot found item group"
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }


                            BaseResultModel resultStockKeepingDayNumber = await CalStockKeepingDay(stockeepingDayInDb, itemHierachyInDb);
                            if (!resultStockKeepingDayNumber.IsSuccess)
                            {
                                return await CreateAuditLog(resultStockKeepingDayNumber, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockKeepingDayNumber = (int)resultStockKeepingDayNumber.Data;
                        }

                        var listCloseQtyInDb = _blCloseQty.Find(x => x.ItemId == data.ItemId &&
                                                            x.DistributorId == data.DistributorId &&
                                                            x.DistributorShipToId == data.DistributorShiptoId &&
                                                            x.BaselineDate == baselineDateNew.Date).ToList();
                        int closeQuantity = 0;
                        int closePurchaseQty = 0;
                        foreach (var closeQty in listCloseQtyInDb)
                        {
                            closeQuantity += closeQty.CloseQuantity != null ? closeQty.CloseQuantity.Value : 0;
                            closePurchaseQty += closeQty.ClosePurchaseQuantity != null ? closeQty.ClosePurchaseQuantity.Value : 0;
                        }

                        data.CloseQuantityByBaseUom = closeQuantity;
                        data.CloseQuantityByPurchaseUom = closePurchaseQty;

                        // Handle Stock keeping number
                        data.SskdayQtyByBaseUom = data.RunningSalesByBaseQty * stockKeepingDayNumber;
                        data.SskdayQtyByPruchaseUom = data.RunningSalesByPurchaseQty * stockKeepingDayNumber;

                        if (data.CloseQuantityByBaseUom >= data.SskdayQtyByBaseUom)
                        {
                            data.Result = true;
                        }
                        else
                        {
                            data.Result = false;
                        }
                    }

                    // List record runningsales by baseline date
                    var listRawSafetyStock = _blSafetyStockAssessmentRepo.Find(x => x.AssessmentDate.Date == baselineDateNew.Date).ToList();

                    // Remove record by baseline date
                    if (listRawSafetyStock != null && listRawSafetyStock.Count > 0)
                    {
                        _blSafetyStockAssessmentRepo.DeleteMany(listRawSafetyStock);
                    }

                    // Insert to database
                    _blSafetyStockAssessmentRepo.InsertMany(listData);

                    return await CreateAuditLog(new BaseResultModel
                    {
                        Code = 200,
                        IsSuccess = true,
                        Message = "Successfully"
                    }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                }
                else
                {
                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listData = listData.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.IN_RECEIPT, dataRequest.HistoryRefNumber);
                    }

                    foreach (var data in listData)
                    {
                        Boolean isCheck = false;
                        DateTime currentDate = DateTime.Today;
                        var stockeepingDayInDb = new PoStockKeepingDay();

                        // SubArea
                        if (data.SubAreaId != null)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.SubAreaId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Area
                        if (data.AreaId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.AreaId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // SubRegion
                        if (data.SubRegionId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.SubRegionId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Region
                        if (data.RegionId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.RegionId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        // Branch
                        if (data.BranchId != null && !isCheck)
                        {
                            var resultStockKeepingDay = await GetDetailStockKeepingDay(data.BranchId);
                            if (!resultStockKeepingDay.IsSuccess)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = resultStockKeepingDay.Code,
                                    IsSuccess = resultStockKeepingDay.IsSuccess,
                                    Message = resultStockKeepingDay.Message
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockeepingDayInDb = resultStockKeepingDay.Data;

                            if (stockeepingDayInDb != null)
                            {
                                isCheck = true;
                            }
                        }

                        int stockKeepingDayNumber = 0;

                        if (isCheck)
                        {
                            var itemHierachyInDb = _itemHierarchyMappingRepo.FirstOrDefault(x => x.Id == data.Hierarchy);
                            if (itemHierachyInDb == null)
                            {
                                return await CreateAuditLog(new BaseResultModel
                                {
                                    Code = 404,
                                    IsSuccess = false,
                                    Message = "Cannot found item group"
                                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }


                            BaseResultModel resultStockKeepingDayNumber = await CalStockKeepingDay(stockeepingDayInDb, itemHierachyInDb);
                            if (!resultStockKeepingDayNumber.IsSuccess)
                            {
                                return await CreateAuditLog(resultStockKeepingDayNumber, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                            }

                            stockKeepingDayNumber = (int)resultStockKeepingDayNumber.Data;
                        }

                        var listCloseQtyInDb = _blCloseQty.Find(x => x.ItemId == data.ItemId &&
                                                            x.DistributorId == data.DistributorId &&
                                                            x.DistributorShipToId == data.DistributorShiptoId &&
                                                            x.BaselineDate == baselineDateNew.Date).ToList();
                        int closeQuantity = 0;
                        int closePurchaseQty = 0;
                        foreach (var closeQty in listCloseQtyInDb)
                        {
                            closeQuantity += closeQty.CloseQuantity != null ? closeQty.CloseQuantity.Value : 0;
                            closePurchaseQty += closeQty.ClosePurchaseQuantity != null ? closeQty.ClosePurchaseQuantity.Value : 0;
                        }

                        data.CloseQuantityByBaseUom = closeQuantity;
                        data.CloseQuantityByPurchaseUom = closePurchaseQty;

                        // Handle Stock keeping number
                        data.SskdayQtyByBaseUom = data.RunningSalesByBaseQty * stockKeepingDayNumber;
                        data.SskdayQtyByPruchaseUom = data.RunningSalesByPurchaseQty * stockKeepingDayNumber;

                        if (data.CloseQuantityByBaseUom >= data.SskdayQtyByBaseUom)
                        {
                            data.Result = true;
                        }
                        else
                        {
                            data.Result = false;
                        }
                    }

                    // List record runningsales by baseline date
                    var listRawSafetyStock = _blSafetyStockAssessmentRepo.Find(x => x.AssessmentDate.Date == baselineDateNew.Date);

                    if (dataRequest.Type.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && dataRequest.ValueCodes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && dataRequest.ValueCodes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && dataRequest.ValueCodes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && dataRequest.ValueCodes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && dataRequest.ValueCodes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && dataRequest.ValueCodes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else if (dataRequest.Type.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        listRawSafetyStock = listRawSafetyStock.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && dataRequest.ValueCodes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == dataRequest.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        }, baselineDateNew, dataRequest.SettingRef, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                    }

                    listRawSafetyStock = listRawSafetyStock.ToList();
                    var itemRemoves = listRawSafetyStock.ToList();

                    // Remove record by baseline date
                    if (itemRemoves != null && itemRemoves.Count > 0)
                    {
                        _blSafetyStockAssessmentRepo.DeleteMany(itemRemoves);
                    }

                    // Insert to database
                    _blSafetyStockAssessmentRepo.InsertMany(listData);

                    return await CreateAuditLog(new BaseResultModel
                    {
                        Code = 200,
                        IsSuccess = true,
                        Message = "Successfully"
                    }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                }, baselineDateNew, null, BlProcessConst.BL_SAFE_STOCK_ACESSMENT, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<ResultModelWithObject<PoStockKeepingDay>> GetDetailStockKeepingDay(string territoryValueKey)
        {
            try
            {
                DateTime currentDate = DateTime.Today;
                var dataResponse = _poStockKeepingDayRepo.FirstOrDefault(x => x.TerritoryLevelValue == territoryValueKey &&
                                                                               (x.EffectiveDate.Date <= currentDate.Date &&
                                                                               ((x.ValidUntil.HasValue &&
                                                                               x.ValidUntil.Value.Date > currentDate.Date) ||
                                                                               !x.ValidUntil.HasValue)) &&
                                                                               !x.IsDeleted);
                return new ResultModelWithObject<PoStockKeepingDay>
                {
                    IsSuccess = true,
                    Code = 200,
                    Data = dataResponse
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new ResultModelWithObject<PoStockKeepingDay>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> CalStockKeepingDay(PoStockKeepingDay stockKeepingInDb, ItemHierarchyMapping itemGroup)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                var itemHierarchies = _poStockKeepingDayItemRepo.Find(x => x.StockKeepingDayNumber == stockKeepingInDb.StockKeepingDayNumber && !x.IsDeleted).ToList();

                if (stockKeepingInDb != null)
                {
                    if (itemGroup.ValuesAttribute10 != Guid.Empty)
                    {
                        var itemHirachy1 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute10);

                        if (itemHirachy1 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy1.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute9 != Guid.Empty)
                    {
                        var itemHirachy2 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute9);

                        if (itemHirachy2 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy2.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute8 != Guid.Empty)
                    {
                        var itemHirachy3 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute8);

                        if (itemHirachy3 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy3.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute7 != Guid.Empty)
                    {
                        var itemHirachy4 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute7);

                        if (itemHirachy4 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy4.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute6 != Guid.Empty)
                    {
                        var itemHirachy5 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute6);

                        if (itemHirachy5 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy5.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute5 != Guid.Empty)
                    {
                        var itemHirachy6 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute5);

                        if (itemHirachy6 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy6.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute4 != Guid.Empty)
                    {
                        var itemHirachy7 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute4);

                        if (itemHirachy7 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy7.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute3 != Guid.Empty)
                    {
                        var itemHirachy8 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute3);

                        if (itemHirachy8 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy8.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute2 != Guid.Empty)
                    {
                        var itemHirachy9 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute2);

                        if (itemHirachy9 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy9.DayNumber
                            };
                        }
                    }

                    if (itemGroup.ValuesAttribute1 != Guid.Empty)
                    {
                        var itemHirachy10 = itemHierarchies
                            .FirstOrDefault(x => x.ItemHierarchyId == itemGroup.ValuesAttribute1);

                        if (itemHirachy10 != null)
                        {
                            return new BaseResultModel
                            {
                                IsSuccess = true,
                                Code = 200,
                                Data = itemHirachy10.DayNumber
                            };
                        }
                    }
                }

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Data = (int)0
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    Code = 500,
                    IsSuccess = true,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> ProcessPoKPI(DateTime baseLineDate, string token)
        {
            try
            {
                string tokenSplit = token.Split(" ").Last();
                _client.Authenticator = new JwtAuthenticator($"Rdos {tokenSplit}");

                var listData = _blRawPo.Find(x => x.BaselineDate.Date == baseLineDate.Date)
                    .Select(x => x.TransactionDate).GroupBy(x => x.Value.Date).Select(x => x.First()).OrderBy(x => x.Value).ToList();

                foreach (var item in listData)
                {
                    var requestKPI = new RestRequest($"calculatekpi/calculationkpiswithpurchaseorder", Method.POST, DataFormat.Json);
                    requestKPI.AddJsonBody(new RequestCalculateKpiModel { IsToPresentTime = true, TimeToCalculateKPIs = item.Value });
                    var resultKPI = _client.Execute(requestKPI);

                    if (resultKPI == null || resultKPI.Content == String.Empty)
                    {
                        return new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = $"Cannot calculate purchase order KPI date: {item.Value}"
                        };
                    }

                    var resultData = JsonConvert.DeserializeObject<BaseResultModel>(JsonConvert.DeserializeObject(resultKPI.Content).ToString());
                    if (!resultData.IsSuccess)
                    {
                        return resultData;
                    }
                }

                return new BaseResultModel
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    Code = 500,
                    IsSuccess = true,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> ProcessSoKPI(DateTime baseLineDate, string token)
        {
            try
            {
                string tokenSplit = token.Split(" ").Last();
                _client.Authenticator = new JwtAuthenticator($"Rdos {tokenSplit}");

                var listDateFinal = new List<DateTime?>();

                // Get list date in Raw so with status = cancel
                var listDataCancel = _blRawSo.Find(x => x.BaselineDate.Date == baseLineDate.Date && x.Status == StatusSOConst.CANCEL)
                    .Select(x => x.CancelDate).GroupBy(x => x.Value.Date).Select(x => x.First()).OrderBy(x => x.Value).ToList();

                listDateFinal.AddRange(listDataCancel);

                // Get list date in Raw so with status != cancel
                var listData = _blRawSo.Find(x => x.BaselineDate.Date == baseLineDate.Date && x.Status != StatusSOConst.CANCEL)
                    .Select(x => x.CompletedDate).GroupBy(x => x.Value.Date).Select(x => x.First()).OrderBy(x => x.Value).ToList();

                listDateFinal.AddRange(listData);

                foreach (var item in listDateFinal.GroupBy(x => x.Value.Date).Select(x => x.First()).OrderBy(x => x.Value).ToList())
                {
                    var requestKPI = new RestRequest($"calculatekpi/calculationkpiswithsalesorder", Method.POST, DataFormat.Json);
                    requestKPI.AddJsonBody(new RequestCalculateKpiModel { IsToPresentTime = true, TimeToCalculateKPIs = item.Value });
                    var resultKPI = _client.Execute(requestKPI);

                    if (resultKPI == null || resultKPI.Content == String.Empty)
                    {
                        return new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = $"Cannot calculate purchase order KPI date: {item.Value}"
                        };
                    }

                    var resultData = JsonConvert.DeserializeObject<BaseResultModel>(JsonConvert.DeserializeObject(resultKPI.Content).ToString());
                    if (!resultData.IsSuccess)
                    {
                        return resultData;
                    }
                }

                return new BaseResultModel
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "Successfully"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    Code = 500,
                    IsSuccess = true,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> ProcessCaculateKPI(ProcessRequest dataRequest, string token)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                var _kpiPO = await ProcessPoKPI(baselineDateNew, token);
                if (!_kpiPO.IsSuccess) return await CreateAuditLog(_kpiPO, baselineDateNew, null, BlProcessConst.CAL_KPI, dataRequest.HistoryRefNumber);

                var _kpiSO = await ProcessSoKPI(baselineDateNew, token);
                if (!_kpiSO.IsSuccess) return await CreateAuditLog(_kpiSO, baselineDateNew, null, BlProcessConst.CAL_KPI, dataRequest.HistoryRefNumber);

                return await CreateAuditLog(new BaseResultModel
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "Successfully"
                }, baselineDateNew, null, BlProcessConst.CAL_KPI, dataRequest.HistoryRefNumber);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    Code = 500,
                    IsSuccess = true,
                    Message = ex.InnerException?.Message ?? ex.Message
                }, baselineDateNew, null, BlProcessConst.CAL_KPI, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<ResultModelWithObject<SaleCalendarGenerate>> GetCalendarGenerate(List<SaleCalendarGenerate> listDataInDb, string calendarType, DateTime dateQuery, bool isPrevious)
        {
            try
            {
                if (isPrevious && calendarType == CalendarConstant.MONTH)
                {
                    int monthCurrent = dateQuery.Month;
                    int yearCurrent = dateQuery.Year;
                    if (monthCurrent == 1)
                    {
                        // Get sales calendar year - 1
                        var saleCalendarPrevious = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == yearCurrent - 1);
                        if (saleCalendarPrevious == null)
                        {
                            return new ResultModelWithObject<SaleCalendarGenerate>
                            {
                                Code = 404,
                                IsSuccess = false,
                                Message = $"Cannot found sale calendar year {yearCurrent - 1} in sale calendar generate",
                            };
                        }

                        var monthOfYearPrevious = _saleCalendarGenerateRepo.FirstOrDefault(x => x.SaleCalendarId == saleCalendarPrevious.Id &&
                                                                                 x.Type == calendarType && x.Ordinal == 12);

                        if (monthOfYearPrevious == null)
                        {
                            return new ResultModelWithObject<SaleCalendarGenerate>
                            {
                                Code = 404,
                                IsSuccess = false,
                                Message = $"Cannot found month {12} of year {yearCurrent - 1} in sale calendar generate",
                            };
                        }

                        return new ResultModelWithObject<SaleCalendarGenerate>
                        {
                            Code = 200,
                            IsSuccess = true,
                            Message = "Successfully",
                            Data = monthOfYearPrevious
                        };
                    }
                    else
                    {
                        var monthOfYearCurrent = listDataInDb.FirstOrDefault(x => x.Type == calendarType && x.Ordinal == monthCurrent - 1);

                        if (monthOfYearCurrent == null)
                        {
                            return new ResultModelWithObject<SaleCalendarGenerate>
                            {
                                Code = 404,
                                IsSuccess = false,
                                Message = $"Cannot found month {monthCurrent - 1} of year {yearCurrent} in sale calendar generate",
                            };
                        }

                        return new ResultModelWithObject<SaleCalendarGenerate>
                        {
                            Code = 200,
                            IsSuccess = true,
                            Message = "Successfully",
                            Data = monthOfYearCurrent
                        };
                    }
                }

                var dataRes = listDataInDb.FirstOrDefault(x => x.Type == calendarType &&
                                                        x.StartDate.Value.Date <= dateQuery.Date &&
                                                        x.EndDate.Value.Date >= dateQuery.Date);

                if (dataRes == null)
                {
                    return new ResultModelWithObject<SaleCalendarGenerate>
                    {
                        Code = 404,
                        IsSuccess = false,
                        Message = $"Cannot found {calendarType} of year {dateQuery.Year} in sale calendar generate",
                    };
                }

                return new ResultModelWithObject<SaleCalendarGenerate>
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "Successfully",
                    Data = dataRes
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new ResultModelWithObject<SaleCalendarGenerate>
                {
                    Code = 500,
                    IsSuccess = true,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public async Task<BaseResultModel> ProcessCusPerDaily(ProcessRequest dataRequest)
        {
            DateTime baselineDateParse = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                bool isRebaseline = false;
                var baselineCurrent = baselineDateParse;
                var userLogin = _blSettingInfoRepo.Find(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).First().CreatedBy;

                // Get sales calendar
                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == (DateTime.Parse(dataRequest.BaselineDate)).Year);
                if (salesCalendar == null)
                {
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found sales calendar"
                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                }

                // Get list calendar generate
                var listCalendarGenerate = _saleCalendarGenerateRepo.Find(x => x.SaleCalendarId == salesCalendar.Id).ToList();

                if (listCalendarGenerate.Count == 0)
                {
                    return await CreateAuditLog(new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found calendar generate"
                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                }

                List<DateTime> listBaselineDate = new List<DateTime>();

                if (string.IsNullOrWhiteSpace(dataRequest.Type) ||
                    string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode) ||
                    dataRequest.ValueCodes == null ||
                    (dataRequest.ValueCodes != null && dataRequest.ValueCodes.Count == 0))
                {
                    isRebaseline = false;
                }
                else
                {
                    isRebaseline = true;
                }


                if (isRebaseline)
                {
                    // Handle baseline date current
                    var currentData = _blCurrentCusPerDailyRepo.FirstOrDefault(x => x != null);
                    if (currentData == null)
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 404,
                            Message = "Cannot reBaseline"
                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                    }

                    baselineCurrent = currentData.BaselineDate;

                    for (var dateCurrent = baselineDateParse.Date; dateCurrent <= baselineCurrent; dateCurrent = dateCurrent.AddDays(1))
                    {
                        listBaselineDate.Add(dateCurrent);
                    }
                }
                else
                {
                    listBaselineDate.Add(baselineDateParse);
                }

                foreach (var baselineDateNew in listBaselineDate)
                {
                    // Get sales period
                    var salesPeriod = _saleCalendarGenerateRepo.FirstOrDefault(x => x.SaleCalendarId == salesCalendar.Id &&
                                                                     x.Type == CalendarConstant.MONTH &&
                                                                     x.StartDate.Value.Date <= baselineDateNew.Date &&
                                                                     x.EndDate.Value.Date >= baselineDateNew.Date);

                    if (salesPeriod == null)
                    {
                        return await CreateAuditLog(new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 404,
                            Message = "Cannot found sales period"
                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                    }

                    // Get list raw so
                    var listRawSo = _blRawSo.Find(x => x.BaselineDate.Date == baselineDateNew.Date &&
                                                 x.CusShiptoAttributeValueId4 != null &&
                                                (x.Status == StatusSOConst.PARTIALDELIVERED ||
                                                x.Status == StatusSOConst.DELIVERED)).ToList();

                    var listRawSoGroup = listRawSo.GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => x.First()).ToList();
                    var listSI = _blSalesIndicatorRepo.GetAll();

                    foreach (var rawSoGroup in listRawSoGroup)
                    {
                        var listCusPerDailyInsert = new List<BlCustomerPerformanceDaily>();

                        // Get baseline date previous
                        var baselineDatePrevious = _blCusPerDailyRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                    x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                    x.BaselineDate.Date < baselineDateNew.Date)
                                                    .OrderByDescending(x => x.BaselineDate.Date).FirstOrDefault();

                        List<BlCustomerPerformanceDaily> listCusPerCurrentFilter = new List<BlCustomerPerformanceDaily>();
                        if (baselineDatePrevious != null)
                        {
                            listCusPerCurrentFilter = _blCusPerDailyRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                              x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                              x.BaselineDate.Date == baselineDatePrevious.BaselineDate.Date).ToList();
                        }


                        var listDataRawSoFilter = listRawSo.Where(x => x.CustomerId == rawSoGroup.CustomerId && x.CustomerShiptoId == rawSoGroup.CustomerShiptoId).ToList();

                        // Visited
                        int visited = 0;

                        foreach (var si in listSI.OrderBy(x => x.Index).ToList())
                        {
                            var dataInsert = new BlCustomerPerformanceDaily();
                            if (si.Siid != SIIDConst.SKUBUYED)
                            {
                                // Common
                                dataInsert.SalesPeriod = salesPeriod.Code;
                                dataInsert.BaselineDate = baselineDateNew.Date;
                                dataInsert.CustomerId = rawSoGroup.CustomerId;
                                dataInsert.CustomerName = rawSoGroup.CustomerName;
                                dataInsert.CustomerShiptoId = rawSoGroup.CustomerShiptoId;
                                dataInsert.CustomerShiptoName = rawSoGroup.CustomerShiptoName;
                                dataInsert.CusShiptoAttributeId = rawSoGroup.CusShiptoAttributeId4;
                                dataInsert.CusShiptoAttributeName = rawSoGroup.CusShiptoAttributeName4;
                                dataInsert.CusShiptoAttributeDesc = rawSoGroup.CusShiptoAttributeDesc4;
                                dataInsert.CusShiptoAttributeValueId = rawSoGroup.CusShiptoAttributeValueId4;
                                dataInsert.CusShiptoAttributeValueDesc = rawSoGroup.CusShiptoAttributeValueDesc4;
                                dataInsert.SalesOrgId = rawSoGroup.SalesOrgId;
                                dataInsert.SalesOrgDesc = rawSoGroup.SalesOrgDesc;
                                dataInsert.BranchId = rawSoGroup.BranchId;
                                dataInsert.BranchName = rawSoGroup.BranchName;
                                dataInsert.RegionId = rawSoGroup.RegionId;
                                dataInsert.RegionName = rawSoGroup.RegionName;
                                dataInsert.SubRegionId = rawSoGroup.SubRegionId;
                                dataInsert.SubRegionName = rawSoGroup.SubRegionName;
                                dataInsert.AreaId = rawSoGroup.AreaId;
                                dataInsert.AreaName = rawSoGroup.AreaName;
                                dataInsert.SubAreaId = rawSoGroup.SubAreaId;
                                dataInsert.SubAreaName = rawSoGroup.SubAreaName;
                                dataInsert.Dsaid = rawSoGroup.Dsaid;
                                dataInsert.Dsadesc = rawSoGroup.Dsadesc;
                                dataInsert.DistributorId = rawSoGroup.DistributorId;
                                dataInsert.DistributorName = rawSoGroup.DistributorName;
                                dataInsert.DistyBillToId = rawSoGroup.DistyBillToId;
                                dataInsert.WarehouseId = rawSoGroup.WarehouseId;
                                dataInsert.WarehouseName = rawSoGroup.WarehouseName;
                                dataInsert.Sicid = rawSoGroup.Sicid;
                                dataInsert.Sicdesc = rawSoGroup.Sicdesc;
                                dataInsert.RouteZoneId = rawSoGroup.RouteZoneId;
                                dataInsert.RouteZoneDesc = rawSoGroup.RouteZoneDesc;
                                dataInsert.RouteZoneType = rawSoGroup.RouteZoneType;
                                dataInsert.RouteZonelocation = rawSoGroup.RouteZonelocation;
                                dataInsert.CreatedDate = DateTime.Now;
                                dataInsert.CreatedBy = userLogin;
                                dataInsert.Id = Guid.NewGuid();

                                dataInsert.Siid = si.Siid;
                                dataInsert.Sidesc = si.Description;
                            }


                            // Calculate Actual volume
                            if (si.Siid == SIIDConst.ACTUALVOLUME)
                            {
                                int value = 0;
                                foreach (var dataValue in listDataRawSoFilter)
                                {
                                    value += dataValue.ShippedBaseQuantities.HasValue ? dataValue.ShippedBaseQuantities.Value : 0;
                                }
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var valueCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.ACTUALVOLUME);
                                    value += Int32.Parse(valueCurrent.Value);
                                }

                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                                continue;
                            }

                            // Calculate actual revenue
                            if (si.Siid == SIIDConst.ACTUALREVENUE)
                            {
                                decimal value = 0;
                                var listDataRowSoFilterGroup = listDataRawSoFilter.GroupBy(x => x.OrderRefNumber).Select(x => x.First()).ToList();
                                foreach (var dataValue in listDataRowSoFilterGroup)
                                {
                                    value += dataValue.ShippedExtendAmt.HasValue ? dataValue.ShippedExtendAmt.Value : 0;
                                }

                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var valueCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.ACTUALREVENUE);
                                    value += Decimal.Parse(valueCurrent.Value);
                                }

                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                                continue;
                            }

                            // Calculate actual PC
                            if (si.Siid == SIIDConst.ACTUALPC)
                            {
                                int value = 0;
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var valueCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.ACTUALPC);
                                    value += Int32.Parse(valueCurrent.Value);
                                }
                                int countSalesOrder = listDataRawSoFilter.GroupBy(x => x.OrderRefNumber).Select(x => x.First()).ToList().Count();
                                dataInsert.Value = (value + countSalesOrder).ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                                continue;
                            }

                            // Calculate actual LPPC
                            if (si.Siid == SIIDConst.ACTUALLPPC)
                            {
                                // Calculate ActualPC
                                int actualPC = 0;
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var valueCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.ACTUALPC);
                                    actualPC += Int32.Parse(valueCurrent.Value);
                                }
                                actualPC = actualPC + listDataRawSoFilter.GroupBy(x => x.OrderRefNumber).Select(x => x.First()).ToList().Count;

                                // Calculate ActualLPPC
                                float value = 0;
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var listSkuBuyedNew = listDataRawSoFilter.GroupBy(x => x.ItemId).Select(x => x.First()).ToList();
                                    var listSkuBuyerCurrent = listCusPerCurrentFilter.Where(x => x.Siid == SIIDConst.SKUBUYED).ToList();
                                    int skuBuyedFinal = listSkuBuyerCurrent.Count();
                                    foreach (var skuBuyedNew in listSkuBuyedNew)
                                    {
                                        if (!listSkuBuyerCurrent.Any(x => x.Value == skuBuyedNew.ItemId))
                                        {
                                            skuBuyedFinal++;
                                        }
                                    }

                                    value = skuBuyedFinal / actualPC;
                                }
                                else
                                {
                                    int skuBuedFinalCurrent = listDataRawSoFilter.GroupBy(x => x.ItemId).Select(x => x.First()).ToList().Count();
                                    value = skuBuedFinalCurrent / actualPC;
                                }
                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                                continue;
                            }

                            // Calculate actual ASO
                            if (si.Siid == SIIDConst.ASO)
                            {
                                int value = 0;
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var valueCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.ACTUALPC);
                                    value += Int32.Parse(valueCurrent.Value);
                                }
                                value += listDataRawSoFilter.Count;

                                if (value > 0)
                                {
                                    dataInsert.Value = 1.ToString();
                                }
                                else
                                {
                                    dataInsert.Value = 0.ToString();
                                }
                                listCusPerDailyInsert.Add(dataInsert);
                                continue;
                            }

                            // Calculate SKU Buyed
                            if (si.Siid == SIIDConst.SKUBUYED)
                            {
                                var listSKUDaily = new List<BlCusPerDailySkubuyedDetail>();
                                var listItemCode = new List<string>();

                                // List item code new
                                var listSkuBuyedNew = listDataRawSoFilter.GroupBy(x => x.ItemId).Select(x => x.First()).Select(x => x.ItemId).ToList();
                                listItemCode.AddRange(listSkuBuyedNew);

                                // List item code before
                                if (listCusPerCurrentFilter.Count > 0 && listCusPerCurrentFilter.First().SalesPeriod == salesPeriod.Code)
                                {
                                    var listSkuBuyerCurrent = listCusPerCurrentFilter.Where(x => x.Siid == SIIDConst.SKUBUYED).Select(x => x.Value).ToList();
                                    listItemCode.AddRange(listSkuBuyerCurrent);
                                }

                                var listItemCodeGroup = listItemCode.GroupBy(x => x).Select(x => x.First()).ToList();

                                // Add data sku buyed
                                foreach (var skuBuyedNew in listItemCodeGroup)
                                {
                                    // Common
                                    var dataSkuInsert = new BlCustomerPerformanceDaily();
                                    dataSkuInsert.SalesPeriod = salesPeriod.Code;
                                    dataSkuInsert.BaselineDate = baselineDateNew.Date;
                                    dataSkuInsert.CustomerId = rawSoGroup.CustomerId;
                                    dataSkuInsert.CustomerName = rawSoGroup.CustomerName;
                                    dataSkuInsert.CustomerShiptoId = rawSoGroup.CustomerShiptoId;
                                    dataSkuInsert.CustomerShiptoName = rawSoGroup.CustomerShiptoName;
                                    dataSkuInsert.CusShiptoAttributeId = rawSoGroup.CusShiptoAttributeId4;
                                    dataSkuInsert.CusShiptoAttributeName = rawSoGroup.CusShiptoAttributeName4;
                                    dataSkuInsert.CusShiptoAttributeDesc = rawSoGroup.CusShiptoAttributeDesc4;
                                    dataSkuInsert.CusShiptoAttributeValueId = rawSoGroup.CusShiptoAttributeValueId4;
                                    dataSkuInsert.CusShiptoAttributeValueDesc = rawSoGroup.CusShiptoAttributeValueDesc4;
                                    dataSkuInsert.SalesOrgId = rawSoGroup.SalesOrgId;
                                    dataSkuInsert.SalesOrgDesc = rawSoGroup.SalesOrgDesc;
                                    dataSkuInsert.BranchId = rawSoGroup.BranchId;
                                    dataSkuInsert.BranchName = rawSoGroup.BranchName;
                                    dataSkuInsert.RegionId = rawSoGroup.RegionId;
                                    dataSkuInsert.RegionName = rawSoGroup.RegionName;
                                    dataSkuInsert.SubRegionId = rawSoGroup.SubRegionId;
                                    dataSkuInsert.SubRegionName = rawSoGroup.SubRegionName;
                                    dataSkuInsert.AreaId = rawSoGroup.AreaId;
                                    dataSkuInsert.AreaName = rawSoGroup.AreaName;
                                    dataSkuInsert.SubAreaId = rawSoGroup.SubAreaId;
                                    dataSkuInsert.SubAreaName = rawSoGroup.SubAreaName;
                                    dataSkuInsert.Dsaid = rawSoGroup.Dsaid;
                                    dataSkuInsert.Dsadesc = rawSoGroup.Dsadesc;
                                    dataSkuInsert.DistributorId = rawSoGroup.DistributorId;
                                    dataSkuInsert.DistributorName = rawSoGroup.DistributorName;
                                    dataSkuInsert.DistyBillToId = rawSoGroup.DistyBillToId;
                                    dataSkuInsert.WarehouseId = rawSoGroup.WarehouseId;
                                    dataSkuInsert.WarehouseName = rawSoGroup.WarehouseName;
                                    dataSkuInsert.Sicid = rawSoGroup.Sicid;
                                    dataSkuInsert.Sicdesc = rawSoGroup.Sicdesc;
                                    dataSkuInsert.RouteZoneId = rawSoGroup.RouteZoneId;
                                    dataSkuInsert.RouteZoneDesc = rawSoGroup.RouteZoneDesc;
                                    dataSkuInsert.RouteZoneType = rawSoGroup.RouteZoneType;
                                    dataSkuInsert.RouteZonelocation = rawSoGroup.RouteZonelocation;
                                    dataSkuInsert.CreatedDate = DateTime.Now;
                                    dataSkuInsert.CreatedBy = userLogin;
                                    dataSkuInsert.Siid = si.Siid;
                                    dataSkuInsert.Sidesc = si.Description;
                                    dataSkuInsert.Id = Guid.NewGuid();

                                    dataSkuInsert.Value = skuBuyedNew;
                                    listCusPerDailyInsert.Add(dataSkuInsert);
                                    listSKUDaily.Add(_mapper.Map<BlCusPerDailySkubuyedDetail>(dataSkuInsert));
                                }

                                // Handle flow sku buyed detail
                                if (isRebaseline)
                                {
                                    var listSkubuyedDetailInDb = _blCusPerDailySkubuyedDetailRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                              x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                              x.BaselineDate.Date == baselineDateNew.Date);

                                    var itemSkubuyedRemoves = listSkubuyedDetailInDb.ToList();
                                    if (itemSkubuyedRemoves.Count > 0)
                                    {
                                        _blCusPerDailySkubuyedDetailRepo.DeleteMany(itemSkubuyedRemoves);
                                    }
                                }
                                _blCusPerDailySkubuyedDetailRepo.InsertMany(listSKUDaily);
                                if (!isRebaseline)
                                {
                                    var listSkuBuyedCurrent = _blCurrentCusPerDailySkubuyedDetailRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId && x.CustomerShiptoId == rawSoGroup.CustomerShiptoId).ToList();
                                    if (listSkuBuyedCurrent.Count > 0)
                                    {
                                        _blCurrentCusPerDailySkubuyedDetailRepo.DeleteMany(listSkuBuyedCurrent);
                                    }
                                    _blCurrentCusPerDailySkubuyedDetailRepo.InsertMany(_mapper.Map<List<BlCurrentCusPerDailySkubuyedDetail>>(listSKUDaily));
                                }

                                if (baselineDateNew.Date == baselineCurrent.Date && isRebaseline)
                                {
                                    var listSkuBuyedCurrent = _blCurrentCusPerDailySkubuyedDetailRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                              x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                              x.BaselineDate.Date == baselineDateNew.Date);

                                    var listSkuBuyedCurrentRemove = listSkuBuyedCurrent.ToList();
                                    if (listSkuBuyedCurrentRemove.Count > 0)
                                    {
                                        _blCurrentCusPerDailySkubuyedDetailRepo.DeleteMany(listSkuBuyedCurrentRemove);
                                    }
                                    _blCurrentCusPerDailySkubuyedDetailRepo.InsertMany(_mapper.Map<List<BlCurrentCusPerDailySkubuyedDetail>>(listSKUDaily));
                                }

                                continue;
                            }

                            // Handle week visited
                            if (si.Siid == SIIDConst.WEEKVISITED)
                            {
                                bool checkWeek = true;
                                if (listCusPerCurrentFilter.Count > 0)
                                {
                                    // Get week current
                                    var weekCurrentInfo = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.WEEK, baselineDateNew.Date, false);
                                    if (!weekCurrentInfo.IsSuccess)
                                    {
                                        return await CreateAuditLog(new BaseResultModel
                                        {
                                            IsSuccess = false,
                                            Code = weekCurrentInfo.Code,
                                            Message = weekCurrentInfo.Message
                                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                    }

                                    // Week current in Database
                                    var weekCurrentInDb = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.WEEK, listCusPerCurrentFilter.First().BaselineDate, false);

                                    if (!weekCurrentInDb.IsSuccess)
                                    {
                                        return await CreateAuditLog(new BaseResultModel
                                        {
                                            IsSuccess = false,
                                            Code = weekCurrentInDb.Code,
                                            Message = weekCurrentInDb.Message
                                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                    }

                                    if (weekCurrentInDb.Data.Code != weekCurrentInfo.Data.Code)
                                    {
                                        checkWeek = false;
                                    }
                                }


                                int value = 0;
                                if (listCusPerCurrentFilter.Count > 0 && checkWeek)
                                {
                                    var weekVisitedCurrent = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.WEEKVISITED).Value;
                                    value += Int32.Parse(weekVisitedCurrent);
                                }

                                // Check visitlist
                                var visitListInDb = _visitListRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                        x.CusShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                        x.RzId == rawSoGroup.RouteZoneId &&
                                                                        x.VisitDate.Value.Date == baselineDateNew.Date &&
                                                                        !(bool)x.RemoteVisit).ToList();

                                if (visitListInDb.Count > 0)
                                {
                                    value += 1;
                                    visited = 1;
                                }
                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                            }

                            // Handle sales period visited
                            if (si.Siid == SIIDConst.SPVISITED)
                            {
                                int value = 0;
                                value += visited;

                                var spCurrentInfo = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.MONTH, baselineDateNew.Date, false);

                                if (!spCurrentInfo.IsSuccess)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = spCurrentInfo.Code,
                                        Message = spCurrentInfo.Message
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }

                                if (listCusPerCurrentFilter.Count > 0)
                                {
                                    var dateCusPerDailyInDb = listCusPerCurrentFilter.First().BaselineDate;
                                    var spCurrentInDbInfo = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.MONTH, dateCusPerDailyInDb.Date, false);

                                    if (!spCurrentInDbInfo.IsSuccess)
                                    {
                                        return await CreateAuditLog(new BaseResultModel
                                        {
                                            IsSuccess = false,
                                            Code = spCurrentInDbInfo.Code,
                                            Message = spCurrentInDbInfo.Message
                                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                    }

                                    if (spCurrentInfo.Code == spCurrentInDbInfo.Code)
                                    {
                                        var spVisitedInDb = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.SPVISITED).Value;
                                        value += Int32.Parse(spVisitedInDb);
                                    }
                                }

                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                            }

                            // Handle quater period visited
                            if (si.Siid == SIIDConst.QUATERVISITED)
                            {
                                int value = 0;
                                value += visited;

                                var spCurrentInfo = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.QUARTER, baselineDateNew.Date, false);

                                if (!spCurrentInfo.IsSuccess)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = spCurrentInfo.Code,
                                        Message = spCurrentInfo.Message
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }

                                if (listCusPerCurrentFilter.Count > 0)
                                {
                                    var dateCusPerDailyInDb = listCusPerCurrentFilter.First().BaselineDate;
                                    var spCurrentInDbInfo = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.QUARTER, dateCusPerDailyInDb.Date, false);

                                    if (!spCurrentInDbInfo.IsSuccess)
                                    {
                                        return await CreateAuditLog(new BaseResultModel
                                        {
                                            IsSuccess = false,
                                            Code = spCurrentInDbInfo.Code,
                                            Message = spCurrentInDbInfo.Message
                                        }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                    }

                                    if (spCurrentInfo.Code == spCurrentInDbInfo.Code)
                                    {
                                        var spVisitedInDb = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.YEARVISITED).Value;
                                        value += Int32.Parse(spVisitedInDb);
                                    }
                                }

                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                            }

                            // Handle year period visited
                            if (si.Siid == SIIDConst.YEARVISITED)
                            {
                                int value = 0;
                                value += visited;
                                int year = baselineDateNew.Year;

                                if (listCusPerCurrentFilter.Count > 0)
                                {
                                    int yearCusPerInDb = listCusPerCurrentFilter.First().BaselineDate.Year;
                                    if (year == yearCusPerInDb)
                                    {
                                        var spVisitedInDb = listCusPerCurrentFilter.First(x => x.Siid == SIIDConst.YEARVISITED).Value;
                                        value += Int32.Parse(spVisitedInDb);
                                    }
                                }

                                dataInsert.Value = value.ToString();
                                listCusPerDailyInsert.Add(dataInsert);
                            }

                            // Handle VPO
                            if (si.Siid == SIIDConst.VPO)
                            {
                                var actualVolumeInserted = listCusPerDailyInsert.FirstOrDefault(x => x.Siid == SIIDConst.ACTUALVOLUME);
                                if (actualVolumeInserted == null)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = 404,
                                        Message = "Cannot found Actual volume"
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }

                                var salePeriodVPO = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.MONTH, baselineDateNew.Date, true);
                                if (!salePeriodVPO.IsSuccess)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = salePeriodVPO.Code,
                                        Message = salePeriodVPO.Message
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }
                                var normVPO = _blNormOfBussinessModelRepo.FirstOrDefault(x => x.BusinessModelId == dataInsert.CusShiptoAttributeId &&
                                                                                        x.SalesPeriod == salePeriodVPO.Data.Code &&
                                                                                        x.Siid == si.Siid);
                                if (normVPO == null)
                                {
                                    dataInsert.Value = 0.ToString();
                                }
                                else
                                {
                                    if (Int32.Parse(normVPO.Value) <= Int32.Parse(actualVolumeInserted.Value))
                                    {
                                        dataInsert.Value = 1.ToString();
                                    }
                                    else
                                    {
                                        dataInsert.Value = 0.ToString();
                                    }
                                }
                                listCusPerDailyInsert.Add(dataInsert);
                            }

                            // Handle LPPC
                            if (si.Siid == SIIDConst.LPPC)
                            {
                                var actualLPPCInserted = listCusPerDailyInsert.FirstOrDefault(x => x.Siid == SIIDConst.ACTUALLPPC);
                                if (actualLPPCInserted == null)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = 404,
                                        Message = "Cannot found Actual LPPC"
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }

                                var salePeriodLPPC = await GetCalendarGenerate(listCalendarGenerate, CalendarConstant.MONTH, baselineDateNew.Date, true);
                                if (!salePeriodLPPC.IsSuccess)
                                {
                                    return await CreateAuditLog(new BaseResultModel
                                    {
                                        IsSuccess = false,
                                        Code = salePeriodLPPC.Code,
                                        Message = salePeriodLPPC.Message
                                    }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
                                }
                                var normLPPC = _blNormOfBussinessModelRepo.FirstOrDefault(x => x.BusinessModelId == dataInsert.CusShiptoAttributeId &&
                                                                                        x.SalesPeriod == salePeriodLPPC.Data.Code &&
                                                                                        x.Siid == si.Siid);
                                if (normLPPC == null)
                                {
                                    dataInsert.Value = 0.ToString();
                                }
                                else
                                {
                                    if (float.Parse(normLPPC.Value) <= float.Parse(actualLPPCInserted.Value))
                                    {
                                        dataInsert.Value = 1.ToString();
                                    }
                                    else
                                    {
                                        dataInsert.Value = 0.ToString();
                                    }
                                }
                                listCusPerDailyInsert.Add(dataInsert);
                            }
                        }
                        // Handle remove if rebaseline
                        if (isRebaseline)
                        {
                            var listCusPerDailyInDb = _blCusPerDailyRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                              x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                              x.BaselineDate.Date == baselineDateNew.Date);

                            var itemCusPerDailyRemoves = listCusPerDailyInDb.ToList();
                            if (itemCusPerDailyRemoves.Count > 0)
                            {
                                _blCusPerDailyRepo.DeleteMany(itemCusPerDailyRemoves);
                            }
                        }

                        _blCusPerDailyRepo.InsertMany(listCusPerDailyInsert);

                        // Handle customer performance daily current
                        if (!isRebaseline)
                        {
                            var listCurrentCusPerDailyInDb = _blCurrentCusPerDailyRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId && x.CustomerShiptoId == rawSoGroup.CustomerShiptoId).ToList();
                            if (listCurrentCusPerDailyInDb.Count > 0)
                            {
                                _blCurrentCusPerDailyRepo.DeleteMany(listCurrentCusPerDailyInDb);
                            }
                            _blCurrentCusPerDailyRepo.InsertMany(_mapper.Map<List<BlCurrentCustomerPerformanceDaily>>(listCusPerDailyInsert));
                        }

                        if (baselineDateNew.Date == baselineCurrent.Date && isRebaseline)
                        {

                            var listCurrentCusPerDailyInDb = _blCurrentCusPerDailyRepo.Find(x => x.CustomerId == rawSoGroup.CustomerId &&
                                                                              x.CustomerShiptoId == rawSoGroup.CustomerShiptoId &&
                                                                              x.BaselineDate.Date == baselineDateNew.Date);


                            var itemCurrentCusPerDailyRemoves = listCurrentCusPerDailyInDb.ToList();
                            if (itemCurrentCusPerDailyRemoves.Count > 0)
                            {
                                _blCurrentCusPerDailyRepo.DeleteMany(itemCurrentCusPerDailyRemoves);
                            }
                            _blCurrentCusPerDailyRepo.InsertMany(_mapper.Map<List<BlCurrentCustomerPerformanceDaily>>(listCusPerDailyInsert));
                        }

                    }
                }
                return await CreateAuditLog(new BaseResultModel
                {
                    Code = 200,
                    IsSuccess = true,
                    Message = "Successfully"
                }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return await CreateAuditLog(new BaseResultModel
                {
                    Code = 500,
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                }, baselineDateParse, null, BlProcessConst.CUS_PER_DAILY, dataRequest.HistoryRefNumber);
            }
        }

        public async Task<BaseResultModel> ProcessOutletAccumulate(ProcessRequest dataRequest)
        {
            DateTime baselineDateNew = DateTime.Parse(dataRequest.BaselineDate);
            try
            {
                // Function query
                var query = @"SELECT * FROM collectoutletaccumulate(@baselinedate)";

                // Handle parameter
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@baselinedate", dataRequest.BaselineDate);

                // Excute query
                var listData = ((List<BlOutletAccumulate>)_dapper.QueryWithParams<BlOutletAccumulate>(query, parameters));
                var groupedByprogram = listData.GroupBy(x => new { x.CustomerId, x.CustomerShiptoId, x.TmkprogramId }).Select(x => new BlOutletAccumulate
                {
                    CustomerId = x.Key.CustomerId,
                    CustomerShiptoId = x.Key.CustomerShiptoId,
                    TmkprogramId = x.Key.TmkprogramId,
                    AccuByProgActual = x.Sum(x => x.AccuByProdActual)
                }).ToList();

                listData = listData.GroupBy(x => new
                {
                    x.CustomerId,
                    x.CustomerName,
                    x.CustomerShiptoId,
                    x.CustomerShiptoName,
                    x.TmkprogramType,
                    x.TmkprogramId,
                    x.TmkprogramDesc,
                    x.FrequencyType,
                    x.FrequnecyValue,
                    x.TmkprogramLevelId,
                    x.TmkprogramLevelDesc,
                    x.AccumulateType,
                    x.AccuByProgTarget,
                    x.ProductType,
                    x.AccuProductId,
                    x.AccuProductDesc,
                    x.AccuByProdTarget,
                    x.AccuByProdTargetUom,
                    x.AccuWeightType,
                    x.AccuWeighProductId,
                    x.AccuWeighProductDesc,
                    x.AccuWeightByProgTarget,
                    x.AccuWeightByProgTargetUom,
                }).Select(x => new BlOutletAccumulate
                {
                    Id = Guid.NewGuid(),
                    BaselineDate = baselineDateNew,
                    CustomerId = x.Key.CustomerId,
                    CustomerName = x.Key.CustomerName,
                    CustomerShiptoId = x.Key.CustomerShiptoId,
                    CustomerShiptoName = x.Key.CustomerShiptoName,
                    TmkprogramType = x.Key.TmkprogramType,
                    TmkprogramId = x.Key.TmkprogramId,
                    TmkprogramDesc = x.Key.TmkprogramDesc,
                    FrequencyType = x.Key.FrequencyType,
                    FrequnecyValue = x.Key.FrequnecyValue,
                    TmkprogramLevelId = x.Key.TmkprogramLevelId,
                    TmkprogramLevelDesc = x.Key.TmkprogramLevelDesc,
                    AccumulateType = x.Key.AccumulateType,
                    AccuByProgTarget = x.Key.AccuByProgTarget,
                    AccuByProgActual = groupedByprogram.Where(y => y.CustomerId == x.Key.CustomerId && y.CustomerShiptoId == x.Key.CustomerShiptoId && y.TmkprogramId == x.Key.TmkprogramId).Select(x => x.AccuByProgActual).FirstOrDefault(),
                    AccuByProgProgress = 0,
                    ProductType = x.Key.ProductType,
                    AccuProductId = x.Key.AccuProductId,
                    AccuProductDesc = x.Key.AccuProductDesc,
                    AccuByProdTarget = x.Key.AccuByProdTarget,
                    AccuByProdTargetUom = x.Key.AccuByProdTargetUom,
                    AccuByProdActual = x.Sum(x => x.AccuByProdActual),
                    AccuByProdActualUom = x.Select(x => x.AccuByProdActualUom).FirstOrDefault(),
                    AccuByProdProgress = 0,
                    AccuWeightType = x.Key.AccuWeightType,
                    AccuWeighProductId = x.Key.AccuWeighProductId,
                    AccuWeighProductDesc = x.Key.AccuWeighProductDesc,
                    AccuWeightByProgTarget = x.Key.AccuWeightByProgTarget,
                    AccuWeightByProgTargetUom = x.Key.AccuWeightByProgTargetUom,
                    AccuWeightByProgActual = x.Sum(x => x.AccuWeightByProgActual),
                    AccuWeightByProgActualUom = x.Select(x => x.AccuWeightByProgActualUom).FirstOrDefault(),
                    AccuWeightByProgProgress = 0,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    CreatedBy = null,
                    UpdatedBy = null,
                    IsDeleted = false,
                }).ToList();

                foreach (var item in listData)
                {
                    var previousRecord = _blOutletAccumulateRepo.Find(x => x.CustomerId == item.CustomerId &&
                        x.CustomerShiptoId == item.CustomerShiptoId &&
                        x.TmkprogramType == item.TmkprogramType &&
                        x.TmkprogramId == item.TmkprogramId &&
                        x.TmkprogramLevelId == item.TmkprogramLevelId &&
                        x.ProductType == item.ProductType &&
                        x.AccuProductId == item.AccuProductId).FirstOrDefault();
                    if (previousRecord != null)
                    {
                        //Cộng dồn vào 
                        // item.AccuByProgActual += previousRecord.AccuByProgActual;
                        item.AccuByProgProgress = item.AccuByProgActual * 100 / item.AccuByProgTarget;
                        item.AccuByProdActual += previousRecord.AccuByProdActual;
                        item.AccuByProdProgress = item.AccuByProdActual * 100 / item.AccuByProdTarget;
                        // item.AccuWeightByProgActual = ;
                        // item.AccuWeightByProgProgress = ;   
                    }
                }

                _blOutletAccumulateRepo.InsertMany(listData);

                var nextBlDate = _blOutletAccumulateRepo.Find(x => x.BaselineDate.Date > baselineDateNew.Date).Select(x => x.BaselineDate).OrderBy(x => x).FirstOrDefault();
                if (nextBlDate != null)
                {
                    var newReq = dataRequest;
                    newReq.BaselineDate = nextBlDate.Date.ToString();
                    await ProcessOutletAccumulate(newReq);
                }
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "Successfully"
                }, baselineDateNew, null, BlProcessConst.OUTLET_ACCUMULATE, dataRequest.HistoryRefNumber);
            }
            catch (System.Exception ex)
            {
                return await CreateAuditLog(new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                }, baselineDateNew, null, BlProcessConst.OUTLET_ACCUMULATE, dataRequest.HistoryRefNumber);
            }
        }

        #region AuditLog
        private async Task<BaseResultModel> CreateAuditLog(BaseResultModel resultLog, DateTime baseLineDate, string settingRef, string processCode, string? historyRefNumber)
        {
            if (settingRef == null)
            {
                var setting = await GetDetailBaselineSetting(null, true);
                settingRef = setting.Data.BlBlsettingInformation.SettingRef;
            }
            _blAuditLogRepo.Insert(new BlAuditLog
            {
                Id = Guid.NewGuid(),
                BaselineSettingRef = settingRef,
                BaselineDate = baseLineDate,
                CreatedDate = DateTime.Now,
                CreatedBy = null,
                ProcessCode = processCode,
                IsSuccess = resultLog.IsSuccess,
                Description = resultLog.Message,
                FinishTime = DateTime.Now,
                UpdatedBy = null,
                RefNumber = historyRefNumber
            });
            return resultLog;
        }
        private async Task<ResultModelWithObject<BaselineSettingDetailModel>> GetDetailBaselineSetting(string? settingRef, bool isCurrent)
        {
            try
            {
                var settingInfo = new BlBlsettingInformation();
                if (isCurrent)
                {
                    settingInfo = _blSettingInfoRepo.Find(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
                }
                else
                {
                    settingInfo = _blSettingInfoRepo.FirstOrDefault(x => !x.IsDeleted && x.SettingRef == settingRef);
                }

                if (settingInfo == null)
                {
                    return new ResultModelWithObject<BaselineSettingDetailModel>
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = $"Cannot found baseline setting {settingRef}"
                    };
                }
                var listTransactionStatus = _blSettingTransactionStatusRepo.Find(x => x != null).ToList();
                var listProcessPending = _blSettingProcessPendingRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingInfo.SettingRef).ToList();
                var listProcess = _blSettingProcessRepo.Find(x => !x.IsDeleted && x.BaselineSettingRef == settingInfo.SettingRef).ToList();
                var listProcessNew = _mapper.Map<List<BlBlsettingProcessDetail>>(listProcess);
                foreach (var item in listProcessNew)
                {
                    var process = _blProcessRepo.FirstOrDefault(x => x.ProcessCode == item.ProcessCode);
                    item.Process = process;
                    item.IsSequentialProcessing = process.IsSequentialProcessing.Value;
                    item.Priority = process.Priority;
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
        #endregion

        #region Handle History
        public async Task<ResultModelWithObject<ListHistoryResponse>> GetListHistoryByBaselineDate(FilterHistoryModel parameters)
        {
            try
            {
                var res = _blHistoryRepo.Find(x =>
                    (parameters.BaselineDate.HasValue ? x.BaselineDate.HasValue && x.BaselineDate.Value.Date == parameters.BaselineDate.Value.Date : true) &&
                    (!string.IsNullOrWhiteSpace(x.Type) && parameters.BLType.Contains(x.Type)));

                if (!string.IsNullOrWhiteSpace(parameters.SalesOrgId))
                {
                    res = res.Where(x => !string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgId);
                }

                if (!string.IsNullOrWhiteSpace(parameters.SalesPeriod))
                {
                    res = res.Where(x => !string.IsNullOrWhiteSpace(x.SalesPeriod) && x.SalesPeriod == parameters.SalesPeriod);
                }
                if (!string.IsNullOrWhiteSpace(parameters.SearchValue))
                {
                    res = res.Where(x =>
                    (!string.IsNullOrWhiteSpace(x.RefNumber) && x.RefNumber.ToLower().Contains(parameters.SearchValue.ToLower())));
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
                var listHistory = res.ToList();
                var listProcessInDb = _blProcessRepo.GetAll();
                var listDataRes = new List<HistoryDetailModel>();

                foreach (var item in listHistory)
                {
                    var dataRes = new HistoryDetailModel();
                    dataRes.HistoryInfo = item;
                    var listAuditlogInDb = _blAuditLogRepo.Find(x => x.RefNumber == item.RefNumber).ToList();
                    var listAuditLogMap = _mapper.Map<List<AuditlogDetailModel>>(listAuditlogInDb);
                    foreach (var auditLog in listAuditLogMap)
                    {
                        var processInDb = listProcessInDb.FirstOrDefault(x => x.ProcessCode == auditLog.ProcessCode);
                        if (processInDb == null)
                        {
                            return new ResultModelWithObject<ListHistoryResponse>
                            {
                                IsSuccess = false,
                                Code = 404,
                                Message = $"Cannot found process {auditLog.ProcessCode}"
                            };
                        }
                        auditLog.ProcessInfo = processInDb;
                    }
                    dataRes.listAuditlog = listAuditLogMap;
                    listDataRes.Add(dataRes);
                }

                listDataRes = listDataRes.OrderByDescending(x => x.HistoryInfo.CreatedDate).ToList();

                if (parameters.IsDropdown)
                {
                    var reponse = new ListHistoryResponse { Items = listDataRes };

                    return new ResultModelWithObject<ListHistoryResponse>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = reponse
                    };
                }
                else
                {
                    var historyTempPagged = PagedList<HistoryDetailModel>.ToPagedList(listDataRes, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
                    var repsonse = new ListHistoryResponse { Items = historyTempPagged, MetaData = historyTempPagged.MetaData };

                    //return metadata
                    return new ResultModelWithObject<ListHistoryResponse>
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
                return new ResultModelWithObject<ListHistoryResponse>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> GetDetailHistory(string refNumber)
        {
            try
            {
                var historyInDb = _blHistoryRepo.FirstOrDefault(x => x.RefNumber == refNumber);
                if (historyInDb == null)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 404,
                        Message = "Cannot found history"
                    };
                }

                var listAuditlogInDb = _blAuditLogRepo.Find(x => x.RefNumber == refNumber).ToList();
                var listAuditLogMap = _mapper.Map<List<AuditlogDetailModel>>(listAuditlogInDb);
                foreach (var item in listAuditLogMap)
                {
                    var processInDb = _blProcessRepo.FirstOrDefault(x => x.ProcessCode == item.ProcessCode);
                    if (processInDb == null)
                    {
                        return new BaseResultModel
                        {
                            IsSuccess = false,
                            Code = 404,
                            Message = $"Cannot found process {item.ProcessCode}"
                        };
                    }
                    item.ProcessInfo = processInDb;
                }

                var dataRes = new HistoryDetailModel();
                dataRes.HistoryInfo = historyInDb;
                dataRes.listAuditlog = listAuditLogMap;

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Get detail successfully",
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
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }
        #endregion

        #region REPORT
        public async Task<ResultModelWithObject<ListDataReportRecipt>> ReportReceipt(ReportParameter parameters)
        {
            try
            {
                var res = _blReceiptyQty.Find(x => !x.IsDeleted);

                if (!string.IsNullOrWhiteSpace(parameters.SalesOrgCode) &&
                    !string.IsNullOrWhiteSpace(parameters.Scope) &&
                    parameters.ValueScopes.Count > 0)
                {
                    if (parameters.Scope.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.BranchId) && parameters.ValueScopes.Contains(x.BranchId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RegionId) && parameters.ValueScopes.Contains(x.RegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubRegionId) && parameters.ValueScopes.Contains(x.SubRegionId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.AreaId) && parameters.ValueScopes.Contains(x.AreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.SubAreaId) && parameters.ValueScopes.Contains(x.SubAreaId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.Dsaid) && parameters.ValueScopes.Contains(x.Dsaid)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.RouteZoneId) && parameters.ValueScopes.Contains(x.RouteZoneId)) &&
                        (!string.IsNullOrWhiteSpace(x.SalesOrgId) && x.SalesOrgId == parameters.SalesOrgCode)).ToList();
                    }
                    else
                    {
                        return new ResultModelWithObject<ListDataReportRecipt>
                        {
                            IsSuccess = false,
                            Code = 400,
                            Message = "Type is incorrect"
                        };
                    }
                }

                if (parameters.TransactionType.Count > 0)
                {
                    res = res.Where(x =>
                        (!string.IsNullOrWhiteSpace(x.InQuantityType) && parameters.TransactionType.Contains(x.InQuantityType))).ToList();
                }

                if (parameters.FromDate.HasValue)
                {
                    res = res.Where(x => x.BaselineDate.Date >= parameters.FromDate.Value.Date);
                }

                if (parameters.ToDate.HasValue)
                {
                    res = res.Where(x => x.BaselineDate.Date <= parameters.ToDate.Value.Date.AddDays(1).AddTicks(-1));
                }

                var listDataFilter = res.ToList();

                List<ReportReciptModel> listRes = new List<ReportReciptModel>();
                foreach (var item in listDataFilter)
                {
                    var itemRes = new ReportReciptModel();
                    if (parameters.Scope.ToLower() == ScopeTypeConst.BRANCH.ToLower())
                    {
                        itemRes.FilterValueCode = item.BranchId;
                        itemRes.FilterValueDescription = item.BranchName;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.REGION.ToLower())
                    {
                        itemRes.FilterValueCode = item.RegionId;
                        itemRes.FilterValueDescription = item.RegionName;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.SUBREGION.ToLower())
                    {
                        itemRes.FilterValueCode = item.SubRegionId;
                        itemRes.FilterValueDescription = item.SubRegionName;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.AREA.ToLower())
                    {
                        itemRes.FilterValueCode = item.AreaId;
                        itemRes.FilterValueDescription = item.AreaName;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.SUBAREA.ToLower())
                    {
                        itemRes.FilterValueCode = item.SubAreaId;
                        itemRes.FilterValueDescription = item.SubAreaName;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.DSA.ToLower())
                    {
                        itemRes.FilterValueCode = item.Dsaid;
                        itemRes.FilterValueDescription = item.Dsadesc;
                    }
                    else if (parameters.Scope.ToLower() == ScopeTypeConst.ROUTEZONE.ToLower())
                    {
                        itemRes.FilterValueCode = item.RouteZoneId;
                        itemRes.FilterValueDescription = item.RouteZoneDesc;
                    }

                    itemRes.ReceiptTypeCode = item.InQuantityType;
                    itemRes.ReceiptTypeDesc = item.InQuantityTypeDesc;
                    itemRes.Item = item.ItemId;
                    itemRes.Description = item.InventoryReportName;
                    itemRes.BaseQuantity = item.InQuantity.Value;
                    itemRes.BaseUom = item.InBaseUom;
                    itemRes.SalesQuantity = item.InSalesQuantity.Value;
                    itemRes.SalesUom = item.InSalesUom;
                    itemRes.PurchaseQuantity = item.InPurchaseQuantity.Value;
                    itemRes.PurchaseUom = item.InPurchaseUom;
                    listRes.Add(itemRes);
                }

                if (parameters.IsDropdown)
                {
                    var reponse = new ListDataReportRecipt { Items = listRes };

                    return new ResultModelWithObject<ListDataReportRecipt>
                    {
                        IsSuccess = true,
                        Code = 200,
                        Message = "Success",
                        Data = reponse
                    };
                }
                else
                {
                    var baselineTempPagged = PagedList<ReportReciptModel>.ToPagedList(listRes, (parameters.PageNumber - 1) * parameters.PageSize, parameters.PageSize);
                    var repsonse = new ListDataReportRecipt { Items = baselineTempPagged, MetaData = baselineTempPagged.MetaData };

                    //return metadata
                    return new ResultModelWithObject<ListDataReportRecipt>
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
                return new ResultModelWithObject<ListDataReportRecipt>
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }
        #endregion
    }
}
