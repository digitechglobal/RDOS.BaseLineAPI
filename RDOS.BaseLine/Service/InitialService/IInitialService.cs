using System.Collections.Generic;
using System.Threading.Tasks;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Services.Interface
{
    public interface IInitialService
    {
        Task<UserInfoClaim> LoginAdmin(string urlCode);
        Task<bool> InitialCron();
        Task<bool> ProcessPendingData();
        Task<bool> HandleBaseLineProcess();

    }
}
