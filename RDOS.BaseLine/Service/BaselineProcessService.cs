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
using static RDOS.BaseLine.Models.Results;

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
        private readonly IBaseRepository<BlIssueQty> _blIssueQty;
        private readonly IBaseRepository<BlReceiptQty> _blReceiptyQty;
        private readonly IBaseRepository<BlCloseStock> _blCloseQty;
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
    }
}
