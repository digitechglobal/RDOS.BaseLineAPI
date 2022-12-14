using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlRawSo
    {
        public Guid Id { get; set; }
        public DateTime BaselineDate { get; set; }
        public string BaselineSettingRef { get; set; }
        public bool? RecordPerformance { get; set; }
        public DateTime? RecordPerformanceUpdateDateTime { get; set; }
        public string RecordPerformanceUpdateBy { get; set; }
        public int? WorkingDay { get; set; }
        public string SalesPeriodId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string VisitId { get; set; }
        public string Sosource { get; set; }
        public string OrderRefNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string ReferenceRefNbr { get; set; }
        public string OrderDescription { get; set; }
        public string SocreatedBy { get; set; }
        public string SoownerId { get; set; }
        public DateTime? CancelDate { get; set; }
        public bool? IsReturn { get; set; }
        public string ReturnNbr { get; set; }
        public bool? IsDirect { get; set; }
        public string OrderType { get; set; }
        public bool? IsPrintedDeliveryNote { get; set; }
        public int? PrintedDeliveryNoteCount { get; set; }
        public DateTime? LastedDeliveryNotePrintDate { get; set; }
        public string MenuType { get; set; }
        public DateTime? ExpectShippedDate { get; set; }
        public string ExpectDeliveryNote { get; set; }
        public string Note { get; set; }
        public int? TotalLine { get; set; }
        public string ReasonId { get; set; }
        public string ReasonDesc { get; set; }
        public bool? NotInSubroute { get; set; }
        public string Status { get; set; }
        public int? OrigOrdSkus { get; set; }
        public int? OrdSkus { get; set; }
        public int? ShippedSkus { get; set; }
        public int? OrigOrdQty { get; set; }
        public int? OrdQty { get; set; }
        public int? ShippedQty { get; set; }
        public int? OrigPromotionQty { get; set; }
        public int? PromotionQty { get; set; }
        public decimal? ShippedPromotionQty { get; set; }
        public decimal? OrigOrdAmt { get; set; }
        public decimal? OrdAmt { get; set; }
        public decimal? ShippedAmt { get; set; }
        public decimal? PromotionAmt { get; set; }
        public decimal? OrigOrdDiscAmt { get; set; }
        public decimal? OrdDiscAmt { get; set; }
        public decimal? ShippedDiscAmt { get; set; }
        public decimal? OrigOrdlineDiscAmt { get; set; }
        public decimal? OrdlineDiscAmt { get; set; }
        public decimal? ShippedlineDiscAmt { get; set; }
        public decimal? OrigOrdExtendAmt { get; set; }
        public decimal? OrdExtendAmt { get; set; }
        public decimal? ShippedExtendAmt { get; set; }
        public decimal? TotalVat { get; set; }
        public int? ConfirmCount { get; set; }
        public string DiscountId { get; set; }
        public string DiscountFullName { get; set; }
        public string DiscountFullShortName { get; set; }
        public string DiscountScheme { get; set; }
        public string PrincipalId { get; set; }
        public string PrincipalDesc { get; set; }
        public string SalesOrgId { get; set; }
        public string SalesOrgDesc { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public string RegionId { get; set; }
        public string RegionName { get; set; }
        public string SubRegionId { get; set; }
        public string SubRegionName { get; set; }
        public string AreaId { get; set; }
        public string AreaName { get; set; }
        public string SubAreaId { get; set; }
        public string SubAreaName { get; set; }
        public string Dsaid { get; set; }
        public string Dsadesc { get; set; }
        public string DistributorId { get; set; }
        public string DistributorName { get; set; }
        public string DistyBillToId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string Sicid { get; set; }
        public string Sicdesc { get; set; }
        public string RouteZoneId { get; set; }
        public string RouteZoneDesc { get; set; }
        public string RouteZoneType { get; set; }
        public string RouteZonelocation { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCountrysId { get; set; }
        public string CustomerCountrysDesc { get; set; }
        public string CustomerCountrysShortName { get; set; }
        public string CustomerStatesId { get; set; }
        public string CustomerStatesDesc { get; set; }
        public string CustomerStatesShortName { get; set; }
        public string CustomerProvincesId { get; set; }
        public string CustomerProvincesDesc { get; set; }
        public string CustomerProvincesShortName { get; set; }
        public string CustomerCitysId { get; set; }
        public string CustomerCitysDesc { get; set; }
        public string CustomerCitysShortName { get; set; }
        public string CustomerDistrictsId { get; set; }
        public string CustomerDistrictsDesc { get; set; }
        public string CustomerDistrictsShortName { get; set; }
        public string CustomerWardsId { get; set; }
        public string CustomerWardsDesc { get; set; }
        public string CustomerWardsShortName { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerDeptNo { get; set; }
        public string CustomerLongtiue { get; set; }
        public string CustomerLattitue { get; set; }
        public string CustomerShiptoId { get; set; }
        public string CustomerShiptoName { get; set; }
        public string CustomerShiptoCountryId { get; set; }
        public string CustomerShiptoCountryDesc { get; set; }
        public string CustomerShiptoStateId { get; set; }
        public string CustomerShiptoStateDesc { get; set; }
        public string CustomerShiptoProvinceId { get; set; }
        public string CustomerShiptoProvinceDesc { get; set; }
        public string CustomerShiptoCityId { get; set; }
        public string CustomerShiptoDesc { get; set; }
        public string CustomerShiptoDistrictId { get; set; }
        public string CustomerShiptoDistrictDesc { get; set; }
        public string CustomerShiptoWardId { get; set; }
        public string CustomerShiptoWardDesc { get; set; }
        public string CustomerShiptoStreet { get; set; }
        public string CustomerShiptoDeptNo { get; set; }
        public string CustomerShiptoLongtiue { get; set; }
        public string CustomerShiptoLattitue { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string NsdmanagerId { get; set; }
        public string NsdmanagerEmpName { get; set; }
        public string BranchManagerId { get; set; }
        public string BranchManagerEmpName { get; set; }
        public string RegionManagerId { get; set; }
        public string RegionManagerEmpName { get; set; }
        public string SubRegionManagerId { get; set; }
        public string SubRegionManagerEmpName { get; set; }
        public string AreaManagerId { get; set; }
        public string AreaManagerEmpName { get; set; }
        public string SubAreaManagerId { get; set; }
        public string SubAreaManagerEmpName { get; set; }
        public string DsamanagerId { get; set; }
        public string DsamanagerEmpName { get; set; }
        public string RzsuppervisorId { get; set; }
        public string RzsuppervisorEmpName { get; set; }
        public string SalesRepId { get; set; }
        public string SalesRepEmpName { get; set; }
        public string CusShiptoAttributeId1 { get; set; }
        public string CusShiptoAttributeName1 { get; set; }
        public string CusShiptoAttributeDesc1 { get; set; }
        public string CusShiptoAttributeValueId1 { get; set; }
        public string CusShiptoAttributeValueDesc1 { get; set; }
        public string CusShiptoAttributeId2 { get; set; }
        public string CusShiptoAttributeName2 { get; set; }
        public string CusShiptoAttributeDesc2 { get; set; }
        public string CusShiptoAttributeValueId2 { get; set; }
        public string CusShiptoAttributeValueDesc2 { get; set; }
        public string CusShiptoAttributeId3 { get; set; }
        public string CusShiptoAttributeName3 { get; set; }
        public string CusShiptoAttributeDesc3 { get; set; }
        public string CusShiptoAttributeValueId3 { get; set; }
        public string CusShiptoAttributeValueDesc3 { get; set; }
        public string CusShiptoAttributeId4 { get; set; }
        public string CusShiptoAttributeName4 { get; set; }
        public string CusShiptoAttributeDesc4 { get; set; }
        public string CusShiptoAttributeValueId4 { get; set; }
        public string CusShiptoAttributeValueDesc4 { get; set; }
        public string CusShiptoAttributeId5 { get; set; }
        public string CusShiptoAttributeName5 { get; set; }
        public string CusShiptoAttributeDesc5 { get; set; }
        public string CusShiptoAttributeValueId5 { get; set; }
        public string CusShiptoAttributeValueDesc5 { get; set; }
        public string CusShiptoAttributeId6 { get; set; }
        public string CusShiptoAttributeName6 { get; set; }
        public string CusShiptoAttributeDesc6 { get; set; }
        public string CusShiptoAttributeValueId6 { get; set; }
        public string CusShiptoAttributeValueDesc6 { get; set; }
        public string CusShiptoAttributeId7 { get; set; }
        public string CusShiptoAttributeName7 { get; set; }
        public string CusShiptoAttributeDesc7 { get; set; }
        public string CusShiptoAttributeValueId7 { get; set; }
        public string CusShiptoAttributeValueDesc7 { get; set; }
        public string CusShiptoAttributeId8 { get; set; }
        public string CusShiptoAttributeName8 { get; set; }
        public string CusShiptoAttributeDesc8 { get; set; }
        public string CusShiptoAttributeValueId8 { get; set; }
        public string CusShiptoAttributeValueDesc8 { get; set; }
        public string CusShiptoAttributeId9 { get; set; }
        public string CusShiptoAttributeName9 { get; set; }
        public string CusShiptoAttributeDesc9 { get; set; }
        public string CusShiptoAttributeValueId9 { get; set; }
        public string CusShiptoAttributeValueDesc9 { get; set; }
        public string CusShiptoAttributeId10 { get; set; }
        public string CusShiptoAttributeName10 { get; set; }
        public string CusShiptoAttributeDesc10 { get; set; }
        public string CusShiptoAttributeValueId10 { get; set; }
        public string CusShiptoAttributeValueDesc10 { get; set; }
        public string InventoryId { get; set; }
        public string InventoryShortName { get; set; }
        public string InventoryReportName { get; set; }
        public string InventoryDescription { get; set; }
        public string Erpid { get; set; }
        public string ItemId { get; set; }
        public string ItemGroupId { get; set; }
        public string ItemGroupDesc { get; set; }
        public string Kitid { get; set; }
        public bool? IsKit { get; set; }
        public string KitshortName { get; set; }
        public string Kitdescription { get; set; }
        public bool? IsFree { get; set; }
        public decimal? UnitPrice { get; set; }
        public Guid? BaseUnitId { get; set; }
        public string BaseUnitDesc { get; set; }
        public Guid? SalesUnitId { get; set; }
        public string SalesUnitDesc { get; set; }
        public Guid? PurchaseUnitId { get; set; }
        public string PurchaseUnitDesc { get; set; }
        public string BaseUomId { get; set; }
        public Guid? Hierarchy { get; set; }
        public string KitKey { get; set; }
        public Guid? Vatid { get; set; }
        public string Vatvalue { get; set; }
        public string Vat { get; set; }
        public string LocationId { get; set; }
        public string LocationDesc { get; set; }
        public int? OriginalOrderQuantities { get; set; }
        public int? OriginalOrderBaseQuantities { get; set; }
        public int? OrderQuantities { get; set; }
        public int? OrderBaseQuantities { get; set; }
        public int? ShippedQuantities { get; set; }
        public int? ShippedBaseQuantities { get; set; }
        public int? FailedBaseQuantities { get; set; }
        public int? FailedQuantities { get; set; }
        public int? ShippingQuantities { get; set; }
        public int? ShippingBaseQuantities { get; set; }
        public int? RemainQuantities { get; set; }
        public string Uom { get; set; }
        public int? UnitRate { get; set; }
        public int? ItemPoint { get; set; }
        public int? ReturnBaseQuantities { get; set; }
        public int? ReturnQuantities { get; set; }
        public string TradePromotionType { get; set; }
        public string PromotionId { get; set; }
        public string PromotionShortName { get; set; }
        public string PromotionFullName { get; set; }
        public string PromotionScheme { get; set; }
        public string ProgramCustomersDetailId { get; set; }
        public string ProgramCustomersShortName { get; set; }
        public string ProgramCustomersFullName { get; set; }
        public string RewardId { get; set; }
        public string RewardDescription { get; set; }
        public decimal? OrigOrdLineAmt { get; set; }
        public decimal? OrdLineAmt { get; set; }
        public decimal? ShippedLineAmt { get; set; }
        public decimal? OrigOrdLineExtendAmt { get; set; }
        public decimal? OrdLineExtendAmt { get; set; }
        public decimal? ShippedLineExtendAmt { get; set; }
        public decimal? DisCountAmount { get; set; }
        public decimal? DiscountPercented { get; set; }
        public string InventoryAttributeId1 { get; set; }
        public string InventoryAttributeName1 { get; set; }
        public string InventoryAttributeDesc1 { get; set; }
        public string InventoryAttributeValueId1 { get; set; }
        public string InventoryAttributeValueDesc1 { get; set; }
        public string InventoryAttributeId2 { get; set; }
        public string InventoryAttributeName2 { get; set; }
        public string InventoryAttributeDesc2 { get; set; }
        public string InventoryAttributeValueId2 { get; set; }
        public string InventoryAttributeValueDesc2 { get; set; }
        public string InventoryAttributeId3 { get; set; }
        public string InventoryAttributeName3 { get; set; }
        public string InventoryAttributeDesc3 { get; set; }
        public string InventoryAttributeValueId3 { get; set; }
        public string InventoryAttributeValueDesc3 { get; set; }
        public string InventoryAttributeId4 { get; set; }
        public string InventoryAttributeName4 { get; set; }
        public string InventoryAttributeDesc4 { get; set; }
        public string InventoryAttributeValueId4 { get; set; }
        public string InventoryAttributeValueDesc4 { get; set; }
        public string InventoryAttributeId5 { get; set; }
        public string InventoryAttributeName5 { get; set; }
        public string InventoryAttributeDesc5 { get; set; }
        public string InventoryAttributeValueId5 { get; set; }
        public string InventoryAttributeValueDesc5 { get; set; }
        public string InventoryAttributeId6 { get; set; }
        public string InventoryAttributeName6 { get; set; }
        public string InventoryAttributeDesc6 { get; set; }
        public string InventoryAttributeValueId6 { get; set; }
        public string InventoryAttributeValueDesc6 { get; set; }
        public string InventoryAttributeId7 { get; set; }
        public string InventoryAttributeName7 { get; set; }
        public string InventoryAttributeDesc7 { get; set; }
        public string InventoryAttributeValueId7 { get; set; }
        public string InventoryAttributeValueDesc7 { get; set; }
        public string InventoryAttributeId8 { get; set; }
        public string InventoryAttributeName8 { get; set; }
        public string InventoryAttributeDesc8 { get; set; }
        public string InventoryAttributeValueId8 { get; set; }
        public string InventoryAttributeValueDesc8 { get; set; }
        public string InventoryAttributeId9 { get; set; }
        public string InventoryAttributeName9 { get; set; }
        public string InventoryAttributeDesc9 { get; set; }
        public string InventoryAttributeValueId9 { get; set; }
        public string InventoryAttributeValueDesc9 { get; set; }
        public string InventoryAttributeId10 { get; set; }
        public string InventoryAttributeName10 { get; set; }
        public string InventoryAttributeDesc10 { get; set; }
        public string InventoryAttributeValueId10 { get; set; }
        public string InventoryAttributeValueDesc10 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
