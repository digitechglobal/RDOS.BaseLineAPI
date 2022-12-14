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
        }

        public async Task<BaseResultModel> ProcesPO(string baselineDate, string settingRef, string userName)
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
    }
}
