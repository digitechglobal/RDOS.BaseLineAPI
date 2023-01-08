using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineProcessService
    {
        Task<BaseResultModel> ProcessPO(string baselineDate, string settingRef);
        Task<BaseResultModel> ProcessInvIssue(string baselineDate, string settingRef, string typeData);
        Task<BaseResultModel> ProcessInvReceipt(string baselineDate, string settingRef, string typeData);
        Task<BaseResultModel> ProcessInvCloseQty(string baselineDate, string settingRef);
        Task<BaseResultModel> ProcessSO(string baselineDate, string settingRef);
        Task<BaseResultModel> ProcessRunningSales(string baselineDate);
        Task<BaseResultModel> ProcessSafetyStockAssessment(string baselineDate);
        Task<BaseResultModel> ProcessCaculateKPI(DateTime baselineDate, string token);
        Task<BaseResultModel> ProcessSoKPI(DateTime baseLineDate, string token);
        Task<BaseResultModel> ProcessCusPerDaily(DateTime baselineDate);
        Task<BaseResultModel> ProcessOutletAccumulate(DateTime baseLineDate);
    }
}
