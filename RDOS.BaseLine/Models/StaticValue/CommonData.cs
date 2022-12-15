using System.Collections.Generic;
using SysAdmin.Models.SystemUrl;

namespace SysAdmin.Models.StaticValue
{
    public static class CommonData
    {
        public static List<SystemUrlModel> SystemUrl { get; set; }
        public static class SystemUrlCode
        {
            public const string KpiCode = "KpiAPI";
            public const string SystemAdminAPI = "SystemAdminAPI";
            public const string RDOSSystem = "SystemAdminAPI";
            public const string SalesOrgAPI = "SalesOrgAPI";
            public const string TpAPICode = "TpAPI";
            public const string InventoryMngCode = "InventoryMngAPI";
            public const string PurchaseOrderCode = "PurchaseOrderAPI";
            public const string RouteMngAPI = "RouteMngAPI";
            public const string SaleOrderAPI = "SaleOrderAPI";
            public const string PriceMngCode = "PriceMngAPI";
        }
    }
}
