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
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaselineReportController : ControllerBase
    {
        private readonly IBaselineProcessService _blProcessService;
        public BaselineReportController(IBaselineProcessService blProcessService)
        {
            _blProcessService = blProcessService;
        }


        [HttpPost]
        [Route("ReportReceipt")]
        public async Task<IActionResult> ReportReceipt(ReportParameter dataInput)
        {
            return Ok(await _blProcessService.ReportReceipt(dataInput));
        }

    }
}
