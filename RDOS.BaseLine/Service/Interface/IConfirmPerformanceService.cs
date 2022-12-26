using RDOS.BaseLine.Models.Request;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IConfirmPerformanceService
    {
        Task<ResultModelWithObject<ListRawSoNotPerformance>> GetListRowSONotPerformance(FilterConfirmPer parameters);
        Task<BaseResultModel> CreateConfirmPerformance(ConfirmPerformanceModel dataInput, string userLogin);
        Task<BaseResultModel> GetDetailConfirmPerformance(string confirmRef);
        Task<ResultModelWithObject<ListonfirmPerforamce>> SearchConfirmPer(ConfirmPerforamceSearch parameters);
        Task<BaseResultModel> UpdateConfirmPerformance(ConfirmPerformanceModel dataInput, string userLogin);
        Task<BaseResultModel> DeleteConfirmPerformance(string confirmRef, string userLogin);
    }
}
