using AutoMapper;
using RDOS.BaseLine.Services.Interface;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nProx.Helpers.JWT;
using nProx.Helpers.Models;
using static SysAdmin.Models.StaticValue.CommonData;
using SysAdmin.Models.StaticValue;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Services
{
    public class InitialService : IInitialService
    {
        private RestClient _client;
        public InitialService(
            )
        {
        }

        public async Task<UserInfoClaim> LoginAdmin(string urlCode)
        {
            try
            {
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == urlCode).Select(x => x.Url).FirstOrDefault());
                // _client.Authenticator = new JwtAuthenticator($"Rdos {token}");
                var req = new RestRequest($"User/Login", Method.POST, DataFormat.Json);
                req.AddJsonBody(new
                {
                    UserName = "admin",
                    Password = "Tinh!@#123",
                    // RememberMe = true,
                    // SessionId = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    // IPAddress = "string",
                    // PrincipalCode = "string"
                });
                var res = await _client.ExecuteAsync<BaseResultModel>(req).ConfigureAwait(false);
                if (res.Data != null && res.Data.Data != null){
                    return JsonConvert.DeserializeObject<UserInfoClaim>(res.Data.Data.ToString());
                }
                // var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> InitialCron()
        {
            try
            {
                var adminClaims = await LoginAdmin(SystemUrlCode.SystemAdminAPI);
                
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == SystemUrlCode.BaselineAPI).Select(x => x.Url).FirstOrDefault());
                _client.Authenticator = new JwtAuthenticator($"Rdos {adminClaims.Token}");
                var req = new RestRequest($"baselinesetting/ExecuteCronFromBLSetting", Method.POST, DataFormat.Json);
                var res = _client.Execute(req);
                // var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> ProcessPendingData()
        {
            try
            {
                var adminClaims = await LoginAdmin(SystemUrlCode.SystemAdminAPI);
                
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == SystemUrlCode.BaselineAPI).Select(x => x.Url).FirstOrDefault());
                _client.Authenticator = new JwtAuthenticator($"Rdos {adminClaims.Token}");
                var req = new RestRequest($"baselinesetting/HandleProcessPendingData", Method.POST, DataFormat.Json);
                var res = _client.Execute(req);
                // var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> HandleBaseLineProcess()
        {
            try
            {
                var adminClaims = await LoginAdmin(SystemUrlCode.SystemAdminAPI);
                
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == SystemUrlCode.BaselineAPI).Select(x => x.Url).FirstOrDefault());
                _client.Authenticator = new JwtAuthenticator($"Rdos {adminClaims.Token}");
                var req = new RestRequest($"baselinesetting/HandleBaseLineProcess", Method.POST, DataFormat.Json);
                var res = _client.Execute(req);
                // var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

    }
}
