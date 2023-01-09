using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineProcessService
    {
        Task<BaseResultModel> ProcessPO(ProcessRequest dataRequest);
        Task<BaseResultModel> ProcessInvIssue(ProcessRequest dataRequest, string typeData);
        Task<BaseResultModel> ProcessInvReceipt(ProcessRequest dataRequest, string typeData);
        Task<BaseResultModel> ProcessInvCloseQty(ProcessRequest dataRequest);
        Task<BaseResultModel> ProcessSO(ProcessRequest dataRequset);
        Task<BaseResultModel> ProcessRunningSales(ProcessRequest dataRequest);
        Task<BaseResultModel> ProcessSafetyStockAssessment(ProcessRequest dataRequest);
        Task<BaseResultModel> ProcessCaculateKPI(DateTime baselineDate, string token);
        Task<BaseResultModel> ProcessSoKPI(DateTime baseLineDate, string token);
        Task<BaseResultModel> ProcessCusPerDaily(DateTime baselineDate);
        Task<BaseResultModel> ProcessOutletAccumulate(DateTime baseLineDate);
    }
}
