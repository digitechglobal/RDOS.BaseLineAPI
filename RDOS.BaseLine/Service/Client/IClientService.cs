using System.Collections.Generic;
using System.Threading.Tasks;

namespace RDOS.BaseLine.Services.Interface
{
    public interface IClientService
    {
        T CommonRequest<T>(string urlCode, string route, RestSharp.Method method, string token, object dataRequest,bool? includeDeleteAll = false);
        Task<T> CommonRequestAsync<T>(string urlCode, string route, RestSharp.Method method, string token, object dataRequest);
    }
}
