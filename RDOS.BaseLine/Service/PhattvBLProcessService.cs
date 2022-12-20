using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers.Services.Repository;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service
{
    public class PhattvBLProcessService : IPhattvBLProcessService
    {
        private readonly ILogger<PhattvBLProcessService> _logger;
        private readonly IBaseRepository<BlBlsettingInformation> _blSettingInfoRepo;
        private readonly IBaseRepository<BlBlsettingProcess> _blSettingProcessRepo;
        private readonly IBaseRepository<BlBlsettingTransactionStatus> _blSettingTransactionStatusRepo;
        private readonly IBaseRepository<BlBlsettingProcessPending> _blSettingProcessPendingRepo;
        private readonly IBaseRepository<BlBlsettingEmail> _blSettingEmailRepo;
        private readonly IBaseRepository<BlBlprocess> _blProcessRepo;
        private readonly IMapper _mapper;

        private readonly IBaselineSettingService _settingService;

        public PhattvBLProcessService(
            ILogger<PhattvBLProcessService> logger,
            IBaseRepository<BlBlsettingInformation> blSettingInfoRepo,
            IBaseRepository<BlBlsettingProcess> blSettingProcessRepo,
            IBaseRepository<BlBlsettingTransactionStatus> blSettingTransactionStatusRepo,
            IBaseRepository<BlBlsettingProcessPending> blSettingProcessPendingRepo,
            IBaseRepository<BlBlsettingEmail> blSettingEmailRepo,
            IBaseRepository<BlBlprocess> blProcessRepo,
            IMapper mapper,
            IBaselineSettingService settingService
            )
        {
            _logger = logger;
            _blSettingInfoRepo = blSettingInfoRepo;
            _blSettingProcessRepo = blSettingProcessRepo;
            _blSettingTransactionStatusRepo = blSettingTransactionStatusRepo;
            _blSettingProcessPendingRepo = blSettingProcessPendingRepo;
            _blSettingEmailRepo = blSettingEmailRepo;
            _blProcessRepo = blProcessRepo;
            _mapper = mapper;
            _settingService = settingService;
        }

        public async Task<BaseResultModel> HandleProcessPendingData()
        {
            try
            {
                var setting = await _settingService.GetCurrentBaselineSetting();
                var processPendingSetting = setting.Data.ProcessPendings;


                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "OK"
                };
            }
            catch (System.Exception ex)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }
    }
}
