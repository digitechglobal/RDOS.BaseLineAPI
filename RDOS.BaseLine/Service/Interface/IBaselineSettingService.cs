using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineSettingService
    {
        Task<BaseResultModel> GetListSettingTransactionStatus();
        Task<BaseResultModel> ChangeSetting(BaselineSettingModel dataInput, string userLogin);
        Task<BaseResultModel> GetDetailBaselineSetting(string settingRef);
        Task<BaseResultModel> GetListProcess();
        Task<ResultModelWithObject<BaselineSettingDetailModel>> GetCurrentBaselineSetting();
        Task<ResultModelWithObject<ListBaselineSetting>> SearchBaselineSetting(BaselineSearch parameters);
        Task<bool> ReSchedular();
    }
}
