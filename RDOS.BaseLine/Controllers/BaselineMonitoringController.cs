using Microsoft.AspNetCore.Mvc;
using nProx.Helpers.Controllers;
using nProx.Helpers.JWT;
using nProx.Helpers.Services.Base;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using System.Security.Cryptography;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Controllers
{
    [Authorize]
    public class BaselineMonitoringController : NormalController<HistoryDetailModel>
    {
        private readonly IBaselineProcessService _blProcessService;
        private readonly IPhattvBLProcessService _phattvBaseLineSettingService;
        public BaselineMonitoringController(
            IBaseService<HistoryDetailModel> service,
            IBaselineProcessService blProcessService,
            IPhattvBLProcessService phattvBaseLineSettingService) : base(service)
        {
            _blProcessService = blProcessService;
            _phattvBaseLineSettingService = phattvBaseLineSettingService;
        }


        [HttpPost]
        [Route("GetListHistory")]
        public async Task<IActionResult> GetListHistory(FilterHistoryModel dataInput)
        {
            return Ok(await _blProcessService.GetListHistoryByBaselineDate(dataInput));
        }


        [HttpGet]
        [Route("GetDetailHistory/{refNumber}")]
        public async Task<IActionResult> GetDetail(string refNumber)
        {
            return Ok(await _blProcessService.GetDetailHistory(refNumber));
        }
        [HttpPost]
        [Route("HandleRebaseline")]
        public async Task<IActionResult> HandleReBaseline(BaselineProcessRequest dataInput)
        {
            var validateResult = await _phattvBaseLineSettingService.ValidateRebaseline(dataInput);
            if (!validateResult.IsSuccess) return Ok(validateResult);

            dataInput.Type = BaselineType.REBASELINE;
            return Ok(await _phattvBaseLineSettingService.HandleBaseLineProcess(dataInput));
        }
    }
}
