using SysAdmin.Models.SystemUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysAdmin.Web.Services.SystemUrl
{
    public interface ISystemUrlService
    {
        public Task<SystemUrlListModel> GetAllSystemUrl();
    }
}
