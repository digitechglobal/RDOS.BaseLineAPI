﻿using Microsoft.AspNetCore.Mvc;
using nProx.Helpers.Controllers;
using nProx.Helpers.JWT;
using nProx.Helpers.Services.Base;
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
        private readonly IBaselineProcessService _blProcessService;
        public BaselineSettingController(
            IBaseService<BaselineSettingModel> service, 
            IBaselineSettingService baseLineSettingService,
            IBaselineProcessService blProcessService) : base(service)
        {
            _baseLineSettingService = baseLineSettingService;
            _blProcessService = blProcessService;
        }

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
            return Ok( await _baseLineSettingService.ChangeSetting(input, username));
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
            return Ok(await _baseLineSettingService.GetBaselineSettingCurrent());
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
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _blProcessService.ProcessPO(input.BaselineDate, input.SettingRef, username));
        }

        [HttpPost]
        [Route("ProcessInvIssue")]
        public async Task<IActionResult> ProcessInvIssue(ProcessRequest input)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _blProcessService.ProcessInvIssue(input.BaselineDate, input.SettingRef, username, BaselineType.DAILY));
        }

        [HttpPost]
        [Route("ProcessInvReceipt")]
        public async Task<IActionResult> ProcessInvReceipt(ProcessRequest input)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _blProcessService.ProcessInvReceipt(input.BaselineDate, input.SettingRef, username, BaselineType.DAILY));
        }
    }
}
