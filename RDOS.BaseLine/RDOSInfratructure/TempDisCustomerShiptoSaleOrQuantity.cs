using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempDisCustomerShiptoSaleOrQuantity
    {
        public Guid Id { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerShiptoCode { get; set; }
        public string? CustomerShiptoName { get; set; }
        public string? Address { get; set; }
        public string? SaleOrgCode { get; set; }
        public string? BranchCode { get; set; }
        public string? RegionCode { get; set; }
        public string? SubRegionCode { get; set; }
        public string? AreaCode { get; set; }
        public string? SubAreaCode { get; set; }
        public string? DsaCode { get; set; }
        public string? RouteZoneCode { get; set; }
        public decimal SaleNumbers { get; set; }
        public decimal QuantityNumbers { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
