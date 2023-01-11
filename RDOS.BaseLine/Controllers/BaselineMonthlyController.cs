using Microsoft.AspNetCore.Mvc;
using nProx.Helpers.Controllers;
using nProx.Helpers.JWT;
using nProx.Helpers.Services.Base;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.Models.Result;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using System.Security.Cryptography;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Controllers
{
    [Authorize]
    public class BaselineMonthlyController : NormalController<HistoryDetailModel>
    {
        private readonly IBaselineProcessService _blProcessService;
        private readonly IPhattvBLProcessService _phattvBaseLineSettingService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string _token;
        public BaselineMonthlyController(
            IBaseService<HistoryDetailModel> service,
            IBaselineProcessService blProcessService,
            IPhattvBLProcessService phattvBaseLineSettingService,
            IHttpContextAccessor contextAccessor) : base(service)
        {
            _blProcessService = blProcessService;
            _phattvBaseLineSettingService = phattvBaseLineSettingService;
            _contextAccessor = contextAccessor;
            _token = _contextAccessor.HttpContext.Request.Headers["Authorization"];
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
        [Route("HandleMonthlyBaseLine")]
        public async Task<IActionResult> HandleMonthlyBaseLine(MonthlyBaseLineReqModel req)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _phattvBaseLineSettingService.HandleMonthlyBaseLine(req, _token, username));
        }
    }
}
