﻿using Microsoft.AspNetCore.Mvc;
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
        public BaselineSettingController(
            IBaseService<BaselineSettingModel> service,
            IBaselineSettingService baseLineSettingService,
            IBaselineProcessService blProcessService,
            IPhattvBLProcessService phattvBaseLineSettingService) : base(service)
        {
            _baseLineSettingService = baseLineSettingService;
            _blProcessService = blProcessService;
            _phattvBaseLineSettingService = phattvBaseLineSettingService;
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
            return Ok(await _baseLineSettingService.ChangeSetting(input, username));
        }

        [HttpGet]
        [Route("GetDetail/{settingRef}")]
        public async Task<IActionResult> ChangeSetting(string settingRef)
        {
            return Ok(await _baseLineSettingService.GetDetailBaselineSetting(settingRef));
        }

        [HttpGet]
        [Route("GetCurrent")]
        public async Task<IActionResult> GetBaselineSettingCurrent()
        {
            return Ok(await _baseLineSettingService.GetCurrentBaselineSetting());
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
            return Ok(await _blProcessService.ProcessPO(input.BaselineDate, input.SettingRef));
        }

        [HttpPost]
        [Route("ProcessInvIssue")]
        public async Task<IActionResult> ProcessInvIssue(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvIssue(input.BaselineDate, input.SettingRef, BaselineType.DAILY));
        }

        [HttpPost]
        [Route("ProcessInvReceipt")]
        public async Task<IActionResult> ProcessInvReceipt(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvReceipt(input.BaselineDate, input.SettingRef, BaselineType.DAILY));
        }

        [HttpPost]
        [Route("ProcessInvClose")]
        public async Task<IActionResult> ProcessInvClose(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessInvCloseQty(input.BaselineDate, input.SettingRef));
        }

        [HttpPost]
        [Route("ProcessSO")]
        public async Task<IActionResult> ProcessSO(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessSO(input.BaselineDate, input.SettingRef));
        }

        [HttpPost]
        [Route("ProcessRunningSales")]
        public async Task<IActionResult> ProcessRunningSales(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessRunningSales(input.BaselineDate));
        }

        [HttpPost]
        [Route("ProcessSafetyStockAssessment")]
        public async Task<IActionResult> ProcessSafetyStockAssessment(ProcessRequest input)
        {
            return Ok(await _blProcessService.ProcessSafetyStockAssessment(input.BaselineDate));
        }

        [HttpPost]
        [Route("HandleProcessPendingData")]
        public async Task<IActionResult> HandleProcessPendingData(DateTime baseLineDate)
        {
            return Ok(await _phattvBaseLineSettingService.HandleProcessPendingData(baseLineDate));
        }

        [HttpPost]
        [Route("HandleCronFromBLSetting")]
        public async Task<IActionResult> HandleCronFromBLSetting()
        {
            return Ok(await _phattvBaseLineSettingService.HandleCronFromBLSetting());
        }
    }
}
