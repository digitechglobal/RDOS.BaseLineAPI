using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IBaselineProcessService
    {
        Task<BaseResultModel> ProcesPO(string baselineDate, string settingRef, string userName);
    }
}
