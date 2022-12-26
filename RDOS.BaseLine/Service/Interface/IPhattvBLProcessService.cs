using Quartz;
using RDOS.BaseLine.Models;
using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IPhattvBLProcessService
    {
        Task<BaseResultModel> HandleCronFromBLSetting();
        // Task<bool> ReSchedular(TriggerKey key, string expressionTime);
        Task<BaseResultModel> HandleProcessPendingData(List<DateTime> listBaseLineDate);
        Task<BaseResultModel> HandleBaseLineProcess(List<DateTime> listBaseLineDate);
        Task<List<DateTime>> GetBaseLineDate();
        Task<bool> DeleteJob(JobMetadata jobMetadata);
    }
}
