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
    public class RebaselineController : NormalController<HistoryDetailModel>
    {
        private readonly IBaselineProcessService _blProcessService;
        private readonly IPhattvBLProcessService _phattvBaseLineSettingService;
        public RebaselineController(
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
        [Route("HandleReBaseline")]
        public async Task<BaseResultModel> HandleReBaseline(BaselineProcessRequest dataInput)
        {
            if (string.IsNullOrWhiteSpace(dataInput.SalesOrgCode))
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 400,
                    Message = "Sales org code cannot null"
                };
            }

            if (dataInput.Scope.ToLower() != ScopeTypeConst.BRANCH.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.REGION.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.SUBREGION.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.AREA.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.SUBAREA.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.ROUTEZONE.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.DSA.ToLower())
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 400,
                    Message = "Scope is incorrect"
                };
            }

            if (dataInput.ValueCodes == null || dataInput.ValueCodes != null && dataInput.ValueCodes.Count == 0)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 400,
                    Message = "List value code cannot null"
                };
            }

            dataInput.Type = BaselineType.REBASELINE;
            return await _phattvBaseLineSettingService.HandleBaseLineProcess(dataInput);
        }
    }
}
