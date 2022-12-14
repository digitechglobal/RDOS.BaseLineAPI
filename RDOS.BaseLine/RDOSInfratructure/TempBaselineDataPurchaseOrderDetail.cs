using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempBaselineDataPurchaseOrderDetail
    {
        public Guid Id { get; set; }
        public string? RequestPurchaseOrder { get; set; }
        public string? InventoryCode { get; set; }
        public string? UoM { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsFree { get; set; }
        public decimal Discount { get; set; }
        public decimal UnitRate { get; set; }
        public decimal Revenue { get; set; }
        public decimal Volumne { get; set; }
        public decimal OrigOrdLineExtendAmt { get; set; }
        public decimal Point { get; set; }
        public decimal ShippedBaseQty { get; set; }
        public decimal ShippedQty { get; set; }
        public decimal OriginalBaseQty { get; set; }
        public decimal ShippedLineExtendAmt { get; set; }
        public Guid Atrribute1 { get; set; }
        public Guid Atrribute10 { get; set; }
        public Guid Atrribute2 { get; set; }
        public Guid Atrribute3 { get; set; }
        public Guid Atrribute4 { get; set; }
        public Guid Atrribute5 { get; set; }
        public Guid Atrribute6 { get; set; }
        public Guid Atrribute7 { get; set; }
        public Guid Atrribute8 { get; set; }
        public Guid Atrribute9 { get; set; }
        public string? BaseUom { get; set; }
        public int ConfirmedQuantity { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? DiscountSchemeId { get; set; }
        public string? ErpCode { get; set; }
        public string? Grponumber { get; set; }
        public Guid Hierarchy { get; set; }
        public bool IsDeleted { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemGroupCode { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemReportName { get; set; }
        public string? Location { get; set; }
        public int OrderQuantity { get; set; }
        public int ReceiptBaseQuantity { get; set; }
        public int ReceiptQuantity { get; set; }
        public string? ShortName { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Vat { get; set; }
        public string? VatCode { get; set; }
        public string? WareHouse { get; set; }
        public string? WareHouseDescription { get; set; }
    }
}
