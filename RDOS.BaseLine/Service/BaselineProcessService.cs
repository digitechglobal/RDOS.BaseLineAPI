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

                // Function query
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

                // Function query
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
    }
}
