using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp.Authenticators;
using SysAdmin.Models.StaticValue;
using Newtonsoft.Json;
using SysAdmin.Models.SystemUrl;
using static SysAdmin.Models.StaticValue.CommonData;

namespace SysAdmin.Web.Services.SystemUrl
{
    public class SystemUrlService : ISystemUrlService
    {
        private readonly IRestClient _client;

        public SystemUrlService()
        {
            _client = new RestClient(Environment.GetEnvironmentVariable("ECOGATEWAY"));
        }

        public async Task<SystemUrlListModel> GetAllSystemUrl()
        {
            try
            {
                var request = new RestRequest($"systemurl/getallsystemurl", Method.GET, DataFormat.Json);
                var result1 = _client.Execute(request);
                if (result1 == null || result1.Content == string.Empty) return new SystemUrlListModel();
                var returnObject = JsonConvert.DeserializeObject<SystemUrlListModel>(JsonConvert.DeserializeObject(result1.Content).ToString());

                if (Environment.GetEnvironmentVariable("ECOGATEWAY") != "prod" || Environment.GetEnvironmentVariable("ECOGATEWAY") != "production")
                {
                    foreach (var item in returnObject.Items)
                    {
                        if (item.Code == SystemUrlCode.InventoryMngCode)
                        {
                            // add manual 
                        }
                        if (item.Code == SystemUrlCode.SaleOrderAPI)
                        {
                            // add manual 
                            // item.Url = "http://localhost:9091/api/v1/";
                            item.Url = "http://103.98.160.114:9091/api/v1";
                        }
                        if (item.Code == SystemUrlCode.BaselineAPI)
                        {
                            // add manual 
                            // item.Url = "http://localhost:9778/api/v1/";
                            item.Url = "http://14.161.18.75:9778/api/v1";
                        }
                    }
                }


                return returnObject;
            }
            catch (System.Exception ex)
            {
#pragma warning disable S112 // General exceptions should never be thrown
                throw new Exception(ex.Message);
#pragma warning restore S112 // General exceptions should never be thrown
            }
        }
    }
}
