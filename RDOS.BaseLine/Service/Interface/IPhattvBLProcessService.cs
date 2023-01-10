using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models;
using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Constants.Constants;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IPhattvBLProcessService
    {
        Task<BaseResultModel> HandleCronFromBLSetting();
        // Task<bool> ReSchedular(TriggerKey key, string expressionTime);
        Task<BaseResultModel> HandleProcessPendingData();
        // Task<BaseResultModel> HandleBaseLineProcess(List<DateTime> listBaseLineDate);
        Task<List<DateTime>> GetBaseLineDate();
        Task<bool> DeleteJob(JobMetadata jobMetadata);
        Task<BaseResultModel> HandleBaseLineProcess(BaselineProcessRequest dataRequest);
        Task<BaseResultModel> ValidateRebaseline(BaselineProcessRequest dataInput);
    }
}
