using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineSettingService
    {
        Task<BaseResultModel> GetListSettingTransactionStatus();
        Task<BaseResultModel> ChangeSetting(BaselineSettingModel dataInput, string userLogin);
        Task<ResultModelWithObject<BaselineSettingDetailModel>> GetDetailBaselineSetting(string? settingRef, bool isCurrent);
        Task<BaseResultModel> GetListProcess();
        Task<ResultModelWithObject<ListBaselineSetting>> SearchBaselineSetting(BaselineSearch parameters);
    }
}
