using Microsoft.AspNetCore.Mvc;
using nProx.Helpers.Controllers;
using nProx.Helpers.JWT;
using nProx.Helpers.Services.Base;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Controllers
{
    [Authorize]
    public class ConfirmPerformanceController : NormalController<ConfirmPerformanceModel>
    {
        private readonly IConfirmPerformanceService _confirmPerService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string _token;
        public ConfirmPerformanceController(
            IBaseService<ConfirmPerformanceModel> service, 
            IConfirmPerformanceService confirmPerService,
            IHttpContextAccessor contextAccessor) : base(service)
        {
            _confirmPerService = confirmPerService;
            _contextAccessor = contextAccessor;
            _token = _contextAccessor.HttpContext.Request.Headers["Authorization"];
        }

        [HttpPost]
        [Route("FilterRawSo")]
        public async Task<IActionResult> FilterRawSo(FilterConfirmPer input)
        {
            return Ok(await _confirmPerService.GetListRowSONotPerformance(input));
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateConfirmPerformacne(ConfirmPerformanceModel input)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok( await _confirmPerService.CreateConfirmPerformance(input, username, _token));
        }

        [HttpPut]
        [Route("Edit")]
        public async Task<IActionResult> UpdateConfirmPerformacne(ConfirmPerformanceModel input)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _confirmPerService.UpdateConfirmPerformance(input, username, _token));
        }

        [HttpDelete]
        [Route("Delete/{confirmRef}")]
        public async Task<IActionResult> DeleteConfirmPerformacne(string confirmRef)
        {
            var username = User.Claims.FirstOrDefault(x => x.Type == CustomClaimType.UserName)?.Value;
            return Ok(await _confirmPerService.DeleteConfirmPerformance(confirmRef, username));
        }

        [HttpPost]
        [Route("GetList")]
        public async Task<IActionResult> GetList(ConfirmPerforamceSearch input)
        {
            return Ok(await _confirmPerService.SearchConfirmPer(input));
        }

        [HttpGet]
        [Route("GetDetail/{confirmRef}")]
        public async Task<IActionResult> GetDetail(string confirmRef)
        {
            return Ok(await _confirmPerService.GetDetailConfirmPerformance(confirmRef));
        }
    }
}
