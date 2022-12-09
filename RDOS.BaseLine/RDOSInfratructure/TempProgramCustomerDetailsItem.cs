using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempProgramCustomerDetailsItem
    {
        public Guid Id { get; set; }
        public string ProgramCustomersDetailCode { get; set; }
        public string PromotionRefNumber { get; set; }
        public string InventoryId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Uomcode { get; set; }
        public bool IsDisCountLine { get; set; }
        public string DiscountLineCode { get; set; }
        public int OrderQuantites { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public double DiscountPercented { get; set; }
        public decimal DisCountAmount { get; set; }
        public bool IsDeleted { get; set; }
        public int BaseOrderQuantities { get; set; }
        public bool IsPromotion { get; set; }
        public string ProgramCustomerItemsGroupCode { get; set; }
        public string PromotionType { get; set; }
        public string Vatcode { get; set; }
        public Guid? VatId { get; set; }
        public decimal VatValue { get; set; }
        public string ItemShortName { get; set; }
        public string PromotionCode { get; set; }
        public Guid? BaseUnit { get; set; }
        public Guid? PurchaseUnit { get; set; }
        public Guid? SalesUnit { get; set; }
        public Guid? ItemId { get; set; }
        public string Description { get; set; }
    }
}
