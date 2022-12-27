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

        public ClientService(ILogger<ClientService> logger,
            IMapper mapper
            )
        {
            _logger = logger;
            _mapper = mapper;
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
                    token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwMDAxMTEiLCJNb2R1bGVUb2tlbiI6ImV5SmhiR2NpT2lKSVV6STFOaUlzSW5SNWNDSTZJa3BYVkNKOS5leUoxYzJWeWJtRnRaU0k2SWpFd01EQXhNVEVpTENKVmMyVnlTVVFpT2lKbU0yWmxOemszTnkwM1pHTmxMVFJsTUdRdFlqVTRaQzFsTkRJMU56YzFObUkwTnpjaUxDSkZiWEJKWkNJNklpSXNJbTVpWmlJNk1UWTNNakUxTnpRME9Td2laWGh3SWpveE5qY3lNVGN4TWpRNUxDSnBZWFFpT2pFMk56SXhOVGMwTkRsOS51YlhIX01HbWFoRHFLbFdweFAxYTFZbE1mT1J1VFkzelotUmdFT3VZUW04IiwiUHJpbmNpcGFsQ29kZSI6Ik9ORVMiLCJyb2xlIjoiRGlzdEFjY291bnRhbnQiLCJuYmYiOjE2NzIxNTc0NDksImV4cCI6MTY3Mjc2MjI0OSwiaWF0IjoxNjcyMTU3NDQ5LCJpc3MiOiJodHRwczovL2dhdGV3YXkucmRvcy52biIsImF1ZCI6Imh0dHBzOi8vZ2F0ZXdheS5yZG9zLnZuIn0.Uk9P6whqSrWGYzEANMVTr27HIAhWIQaiVG8T78OTyik";
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
                //     dataRequest = JsonConvert.SerializeObject(dataRequest, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                // }
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
