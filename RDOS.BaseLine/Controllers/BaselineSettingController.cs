using Microsoft.AspNetCore.Mvc;
using nProx.Helpers.Controllers;
using nProx.Helpers.JWT;
using nProx.Helpers.Services.Base;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Controllers
{
    [Authorize]
    public class BaselineSettingController : NormalController<BaselineSettingModel>
    {
        private readonly IBaselineSettingService _baseLineSettingService;
        private readonly IPhattvBLProcessService _phattvBaseLineSettingService;
        private readonly IBaselineProcessService _blProcessService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string _token;
        public BaselineSettingController(
            IBaseService<BaselineSettingModel> service,
            IBaselineSettingService baseLineSettingService,
            IBaselineProcessService blProcessService,
            IPhattvBLProcessService phattvBaseLineSettingService,
            IHttpContextAccessor contextAccessor) : base(service)
        {
            _baseLineSettingService = baseLineSettingService;
            _blProcessService = blProcessService;
            _phattvBaseLineSettingService = phattvBaseLineSettingService;
            _contextAccessor = contextAccessor;
            _token = _contextAccessor.HttpContext.Request.Headers["Authorization"];
        }

        // [HttpGet]
        // [Route("reschedule")]
        // public async Task<IActionResult> reschedule()
        // {
        //     return Ok(await _phattvBaseLineSettingService.ReSchedular(new TriggerKey("BLPendingProcess", "DailyBaseLine"), "0/1 * * * * ?"));
        // }

        [HttpGet]
        [Route("GetTransactionStatus")]
        public async Task<IActionResult> GetListSettingTransactionStatus()
        {
            return Ok(await _baseLineSettingService.GetListSettingTransactionStatus());
        }

        [HttpGet]
        [Route("GetListProcess")]
        public async Task<IActionResult> GetListProcess()
        {
            return Ok(await _baseLineSettingService.GetListProcess());
        }

        [HttpPost]
        [Route("ChangeSetting")]
        public async Task<IActionResult> ChangeSetting(BaselineSettingModel input)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            var result = await _baseLineSettingService.ChangeSetting(input, username);
            await _phattvBaseLineSettingService.HandleCronFromBLSetting();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetDetail/{settingRef}")]
        public async Task<IActionResult> GetDetail(string settingRef)
        {
            return Ok(await _baseLineSettingService.GetDetailBaselineSetting(settingRef, false));
        }

        [HttpGet]
        [Route("GetCurrent")]
        public async Task<IActionResult> GetBaselineSettingCurrent()
        {
            return Ok(await _baseLineSettingService.GetDetailBaselineSetting(null, true));
        }

        [HttpPost]
        [Route("GetList")]
        public async Task<IActionResult> GetList(BaselineSearch input)
        {
            return Ok(await _baseLineSettingService.SearchBaselineSetting(input));
        }

        [HttpPost]
        [Route("ProcessPO")]
        public async Task<IActionResult> ProcessPO(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessPO(input));
        }

        [HttpPost]
        [Route("ProcessInvIssue")]
        public async Task<IActionResult> ProcessInvIssue(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvIssue(input, BaselineType.DAILY));
        }

        [HttpPost]
        [Route("ProcessInvReceipt")]
        public async Task<IActionResult> ProcessInvReceipt(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvReceipt(input, BaselineType.DAILY));
        }

        [HttpPost]
        [Route("ProcessInvClose")]
        public async Task<IActionResult> ProcessInvClose(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvCloseQty(input));
        }

        [HttpPost]
        [Route("ProcessSO")]
        public async Task<IActionResult> ProcessSO(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessSO(input));
        }

        [HttpPost]
        [Route("ProcessRunningSales")]
        public async Task<IActionResult> ProcessRunningSales(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessRunningSales(input));
        }

        [HttpPost]
        [Route("ProcessSafetyStockAssessment")]
        public async Task<IActionResult> ProcessSafetyStockAssessment(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessSafetyStockAssessment(input));
        }

        [HttpPost]
        [Route("HandleProcessPendingData")]
        public async Task<IActionResult> HandleProcessPendingData()
        {
            return Ok(await _phattvBaseLineSettingService.HandleProcessPendingData());
        }

        [HttpPost]
        [Route("HandleCronFromBLSetting")]
        public async Task<IActionResult> HandleCronFromBLSetting()
        {
            return Ok(await _phattvBaseLineSettingService.HandleCronFromBLSetting());
        }

        [HttpPost]
        [Route("ProcessCalculateKPI/{baselineDate}")]
        public async Task<IActionResult> ProcessCalculateKPI(DateTime baselineDate)
        {
            return Ok(await _blProcessService.ProcessCaculateKPI(baselineDate, _token));
        }

        [HttpPost]
        [Route("ProcessCustomerPerformance/{baselineDate}")]
        public async Task<IActionResult> ProcessCustomerPerformance(DateTime baselineDate)
        {
            return Ok(await _blProcessService.ProcessCusPerDaily(baselineDate));
        }

        [HttpPost]
        [Route("ExecuteCronFromBLSetting")]
        public async Task<IActionResult> HandleCronFromBLSetting(DateTime baselineDate)
        {
            return Ok(await _phattvBaseLineSettingService.HandleCronFromBLSetting());
        }

        [HttpPost]
        [Route("HandleBaseLineProcess")]
        public async Task<IActionResult> HandleBaseLineProcess()
        {
            return Ok(await _phattvBaseLineSettingService.HandleBaseLineProcess());
        }


    }
}
