using RDOS.BaseLine.RDOSInfratructure;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Models.Request
{
    public class BaselineSettingModel
    {
        public string Description { get; set; }
        public int LeadDate { get; set; } = 0;
        public int MonthlyBaselineDate { get; set; } = 0;
        public bool IsProcessPendingData { get; set; } = false;
        public string ProcessPendingTime { get; set; }
        public string ProcessTime { get; set; }
        public virtual List<ProcessPendingModel> ProcessPendings { get; set; }
        public virtual List<BaseLineProcessModel> BaseLineProcesses { get; set; }
        public BaselineSettingEmailModel? BaselineSettingEmail { get; set; }
    }

    public class ProcessPendingModel
    {
        public string Description { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
    }

    public class BaseLineProcessModel
    {
        public string ProcessCode { get; set; }
        public int? Priority { get; set; } = 0;
        public bool? IsSequentialProcessing { get; set; } = false;
    }

    public class BaselineSettingEmailModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }

    // Model detail
    public class BlBlsettingProcessDetail : BlBlsettingProcess
    {
        public BlBlprocess Process { get; set; }
    }
    public class BaselineSettingDetailModel
    {
        public BlBlsettingInformation BlBlsettingInformation { get; set; }
        public virtual List<BlBlsettingProcessPending> ProcessPendings { get; set; }
        public virtual List<BlBlsettingProcessDetail> BaseLineProcesses { get; set; }
        public BlBlsettingEmail? BaselineSettingEmail { get; set; }
    }

    public class ListBaselineSetting
    {
        public List<BlBlsettingInformation> Items { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class BaselineSearch : EcoParameters
    {

    }

    public class ProcessRequest
    {
        public string BaselineDate { get; set; }
        public string SettingRef { get; set; }
    }
    public class POCollection
    {
        public Guid Id { get; set; }
        public string PurchaseOrderNumber { get; set; } = null!;
        public string? Podescription { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? ExpectReDate { get; set; }
        public string PoconfirmNumber { get; set; } = null!;
        public string? PoPrincipalNumber { get; set; }
        public DateTime? PoconfirmDate { get; set; }
        public string? PoconfirmDescription { get; set; }
        public string Grponumber { get; set; } = null!;
        public DateTime? Grpodate { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? PrincipalRefNumber { get; set; }
        public string? ItemId { get; set; }
        public string? InventoryShortName { get; set; }
        public string? InventoryReportName { get; set; }
        public string? InventoryDescription { get; set; }
        public string? Erpid { get; set; }
        public string? ItemGroupId { get; set; }
        public int? OrderQuantity { get; set; }
        public string? OrderUom { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? OrderBaseQuantity { get; set; }
        public string? OrderBaseUom { get; set; }
        public int? ConfirmedQuantity { get; set; }
        public string? ConfirmedUom { get; set; }
        public int? ConfirmedBaseQuantity { get; set; }
        public string? ConfirmedBaseUom { get; set; }
        public int? ReceiptQuantity { get; set; }
        public string? ReceiptUom { get; set; }
        public int? ReceiptBaseQuantity { get; set; }
        public string? ReceiptBaseUom { get; set; }
        public decimal? Vat { get; set; }
        public string? VatId { get; set; }
        public bool? IsFree { get; set; }
        public string? DiscountSchemeId { get; set; }
        public string? PromotionId { get; set; }
        public string? PromotionShortName { get; set; }
        public string? PromotionFullName { get; set; }
        public string? PromotionScheme { get; set; }
        public string? DistributorId { get; set; }
        public string? DistributorName { get; set; }
        public string? Dmscode { get; set; }
        public string? PrincipalLinkedCode { get; set; }
        public string? DistributorCountrysId { get; set; }
        public string? DistributorCountrysDesc { get; set; }
        public string? DistributorCountrysShortName { get; set; }
        public string? DistributorStatesId { get; set; }
        public string? DistributorStatesDesc { get; set; }
        public string? DistributorStatesShortName { get; set; }
        public string? DistributorProvincesId { get; set; }
        public string? DistributorProvincesDesc { get; set; }
        public string? DistributorProvincesShortName { get; set; }
        public string? DistributorCitysId { get; set; }
        public string? DistributorCitysDesc { get; set; }
        public string? DistributorCitysShortName { get; set; }
        public string? DistributorDistrictsId { get; set; }
        public string? DistributorDistrictsDesc { get; set; }
        public string? DistributorDistrictsShortName { get; set; }
        public string? DistributorWardsId { get; set; }
        public string? DistributorWardsDesc { get; set; }
        public string? DistributorWardsShortName { get; set; }
        public string? DistributorStreet { get; set; }
        public string? DistributorDeptNo { get; set; }
        public string? DistributorLongtiue { get; set; }
        public string? DistributorLattitue { get; set; }
        public string? DistributorShiptoId { get; set; }
        public string? ShiptoName { get; set; }
        public string? ShiptoCodeOnErp { get; set; }
        public string? DistributorShipToFullName { get; set; }
        public string? DistributorShipToCountrysId { get; set; }
        public string? DistributorShipToCountrysDesc { get; set; }
        public string? DistributorShipToCountrysShortName { get; set; }
        public string? DistributorShipToStatesId { get; set; }
        public string? DistributorShipToStatesDesc { get; set; }
        public string? DistributorShipToStatesShortName { get; set; }
        public string? DistributorShipToProvincesId { get; set; }
        public string? DistributorShipToProvincesDesc { get; set; }
        public string? DistributorShipToProvincesShortName { get; set; }
        public string? DistributorShipToCitysId { get; set; }
        public string? DistributorShipToCitysDesc { get; set; }
        public string? DistributorShipToCitysShortName { get; set; }
        public string? DistributorShipToDistrictsId { get; set; }
        public string? DistributorShipToDistrictsDesc { get; set; }
        public string? DistributorShipToDistrictsShortName { get; set; }
        public string? DistributorShipToWardsId { get; set; }
        public string? DistributorShipToWardsDesc { get; set; }
        public string? DistributorShipToWardsShortName { get; set; }
        public string? DistributorShipToStreet { get; set; }
        public string? DistributorShipToDeptNo { get; set; }
        public string? DistributorShipToLongtiue { get; set; }
        public string? DistributorShipToLattitue { get; set; }
        public string? Channels { get; set; }
        public string? SubChanels { get; set; }
        public string? SicId { get; set; }
        public string? PrincipalWareHouseId { get; set; }
        public string? InventoryAttributeId1 { get; set; }
        public string? InventoryAttributeName1 { get; set; }
        public string? InventoryAttributeDesc1 { get; set; }
        public string? InventoryAttributeValueId1 { get; set; }
        public string? InventoryAttributeValueDesc1 { get; set; }
        public string? InventoryAttributeId2 { get; set; }
        public string? InventoryAttributeName2 { get; set; }
        public string? InventoryAttributeDesc2 { get; set; }
        public string? InventoryAttributeValueId2 { get; set; }
        public string? InventoryAttributeValueDesc2 { get; set; }
        public string? InventoryAttributeId3 { get; set; }
        public string? InventoryAttributeName3 { get; set; }
        public string? InventoryAttributeDesc3 { get; set; }
        public string? InventoryAttributeValueId3 { get; set; }
        public string? InventoryAttributeValueDesc3 { get; set; }
        public string? InventoryAttributeId4 { get; set; }
        public string? InventoryAttributeName4 { get; set; }
        public string? InventoryAttributeDesc4 { get; set; }
        public string? InventoryAttributeValueId4 { get; set; }
        public string? InventoryAttributeValueDesc4 { get; set; }
        public string? InventoryAttributeId5 { get; set; }
        public string? InventoryAttributeName5 { get; set; }
        public string? InventoryAttributeDesc5 { get; set; }
        public string? InventoryAttributeValueId5 { get; set; }
        public string? InventoryAttributeValueDesc5 { get; set; }
        public string? InventoryAttributeId6 { get; set; }
        public string? InventoryAttributeName6 { get; set; }
        public string? InventoryAttributeDesc6 { get; set; }
        public string? InventoryAttributeValueId6 { get; set; }
        public string? InventoryAttributeValueDesc6 { get; set; }
        public string? InventoryAttributeId7 { get; set; }
        public string? InventoryAttributeName7 { get; set; }
        public string? InventoryAttributeDesc7 { get; set; }
        public string? InventoryAttributeValueId7 { get; set; }
        public string? InventoryAttributeValueDesc7 { get; set; }
        public string? InventoryAttributeId8 { get; set; }
        public string? InventoryAttributeName8 { get; set; }
        public string? InventoryAttributeDesc8 { get; set; }
        public string? InventoryAttributeValueId8 { get; set; }
        public string? InventoryAttributeValueDesc8 { get; set; }
        public string? InventoryAttributeId9 { get; set; }
        public string? InventoryAttributeName9 { get; set; }
        public string? InventoryAttributeDesc9 { get; set; }
        public string? InventoryAttributeValueId9 { get; set; }
        public string? InventoryAttributeValueDesc9 { get; set; }
        public string? InventoryAttributeId10 { get; set; }
        public string? InventoryAttributeName10 { get; set; }
        public string? InventoryAttributeDesc10 { get; set; }
        public string? InventoryAttributeValueId10 { get; set; }
        public string? InventoryAttributeValueDesc10 { get; set; }
        public Guid? Hierarchy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
