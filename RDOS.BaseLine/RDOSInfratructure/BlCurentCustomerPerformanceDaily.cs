using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlCurentCustomerPerformanceDaily
    {
        public Guid Id { get; set; }
        public DateTime BaselineDate { get; set; }
        public string? SalesPeriod { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerShiptoId { get; set; }
        public string? CustomerShiptoName { get; set; }
        public string? Siid { get; set; }
        public string? Sidesc { get; set; }
        public string? Value { get; set; }
        public string? CusShiptoAttributeId4 { get; set; }
        public string? CusShiptoAttributeName4 { get; set; }
        public string? CusShiptoAttributeDesc4 { get; set; }
        public string? CusShiptoAttributeValueId4 { get; set; }
        public string? CusShiptoAttributeValueDesc4 { get; set; }
        public string? SalesOrgId { get; set; }
        public string? SalesOrgDesc { get; set; }
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? SubRegionId { get; set; }
        public string? SubRegionName { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? SubAreaId { get; set; }
        public string? SubAreaName { get; set; }
        public string? Dsaid { get; set; }
        public string? Dsadesc { get; set; }
        public string? DistributorId { get; set; }
        public string? DistributorName { get; set; }
        public string? DistyBillToId { get; set; }
        public string? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public string? Sicid { get; set; }
        public string? Sicdesc { get; set; }
        public string? RouteZoneId { get; set; }
        public string? RouteZoneDesc { get; set; }
        public string? RouteZoneType { get; set; }
        public string? RouteZonelocation { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
