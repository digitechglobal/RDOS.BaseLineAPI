using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineProcessService
    {
        Task<BaseResultModel> ProcessPO(string baselineDate, string settingRef, string userName);
        Task<BaseResultModel> ProcessInvIssue(string baselineDate, string settingRef, string userName, string typeData);
        Task<BaseResultModel> ProcessInvReceipt(string baselineDate, string settingRef, string userName, string typeData);
        Task<BaseResultModel> ProcessInvCloseQty(string baselineDate, string settingRef, string userName);
        Task<BaseResultModel> ProcessSO(string baselineDate, string settingRef, string userName);
    }
}
