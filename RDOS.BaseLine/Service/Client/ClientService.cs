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

namespace RDOS.BaseLine.Services
{
    public class ClientService : IClientService
    {
        private readonly ILogger<ClientService> _logger;
        private readonly IMapper _mapper;
        private RestClient _client;
        private readonly IJwtUtils _jwtUtils;

        public ClientService(ILogger<ClientService> logger,
            IMapper mapper,
            IJwtUtils jwtUtils
            )
        {
            _logger = logger;
            _mapper = mapper;
            _jwtUtils = jwtUtils;
        }

        public T CommonRequest<T>(string urlCode, string route, RestSharp.Method method, string token, object dataRequest, bool? includeDeleteAll = false)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(token))
                {
                    token = token.Split(" ").Last();
                }
                // if (urlCode == SystemUrlCode.StagingApi)
                // {
                //     Auth auth = new Auth()
                //     {
                //         UserName = "0111111198",
                //         Password = "123456Ab"
                //     };
                //     string jwt = "Bearer " + _jwtUtils.GenerateJwtToken(auth, Guid.NewGuid().ToString(), "");
                //     token = jwt;
                //     if (dataRequest != null)
                //     {
                //         dataRequest = JsonConvert.SerializeObject(dataRequest, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                //     }

                // }
                var a = CommonData.SystemUrl;
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == urlCode).Select(x => x.Url).FirstOrDefault());
                _client.Authenticator = new JwtAuthenticator($"Rdos {token}");
                var req = new RestRequest($"{route}", method, DataFormat.Json);
                if (dataRequest != null)
                {
                    req.AddJsonBody(dataRequest);
                    req.AddQueryParameter("includeDeleteAll", includeDeleteAll.ToString());
                }
                var res = _client.Execute(req);
                var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return result;
            }
            catch (System.Exception ex)
            {
                return default(T);
            }
        }


        public async Task<T> CommonRequestAsync<T>(string urlCode, string route, RestSharp.Method method, string token, object dataRequest)
        {
            try
            {
                if (token != null)
                {
                    token = token.Split(" ").Last();
                }
                else
                {
                    if (urlCode != SystemUrlCode.StagingApi)
                    {
                        Auth auth = new Auth()
                        {
                            UserName = "admin",
                            Password = "Tinh!@#123"
                        };
                        string jwt = _jwtUtils.GenerateJwtToken(auth, Guid.NewGuid().ToString(), "");
                        token = jwt;
                        dataRequest = JsonConvert.SerializeObject(dataRequest, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                    }
                }
                if (urlCode == SystemUrlCode.StagingApi)
                {
                    Auth auth = new Auth()
                    {
                        UserName = "0111111198",
                        Password = "123456Ab"
                    };
                    string jwt = "Bearer " + _jwtUtils.GenerateJwtToken(auth, Guid.NewGuid().ToString(), "");
                    token = jwt;
                    dataRequest = JsonConvert.SerializeObject(dataRequest, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                }
                _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == urlCode).Select(x => x.Url).FirstOrDefault());
                _client.Authenticator = new JwtAuthenticator($"Rdos {token}");
                var req = new RestRequest($"{route}", method, DataFormat.Json);
                if (dataRequest != null)
                {
                    req.AddJsonBody(dataRequest);
                }
                var res = _client.Execute(req);
                var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                return result;
            }
            catch (System.Exception ex)
            {
                return default(T);
            }
        }

        /* public T CommonDeleteRequestForSyncDataSomeTable<T>(string urlCode, string route, RestSharp.Method method, string token, object dataRequest, string? programtyle)
         {
             try
             {
                 if (!string.IsNullOrWhiteSpace(token))
                 {
                     token = token.Split(" ").Last();
                 }
                 if (urlCode == SystemUrlCode.StagingApi)
                 {
                     Auth auth = new Auth()
                     {
                         UserName = "0111111198",
                         Password = "123456Ab"
                     };
                     string jwt = "Bearer " + _jwtUtils.GenerateJwtToken(auth, Guid.NewGuid().ToString(), "");
                     token = jwt;
                     if (dataRequest != null)
                     {
                         dataRequest = JsonConvert.SerializeObject(dataRequest, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                     }

                 }
                 var a = CommonData.SystemUrl;
                 _client = new RestClient(CommonData.SystemUrl.Where(x => x.Code == urlCode).Select(x => x.Url).FirstOrDefault());
                 _client.Authenticator = new JwtAuthenticator($"Rdos {token}");
                 var req = new RestRequest($"{route}", method, DataFormat.Json);
                 if (dataRequest != null)
                 {
                     req.AddJsonBody(dataRequest);
                     req.AddQueryParameter("programtyle", programtyle);
                 }
                 var res = _client.Execute(req);
                 var result = JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject(res.Content).ToString());

                 return result;
             }
             catch (System.Exception ex)
             {
                 return default(T);
             }
         }*/

    }
}
