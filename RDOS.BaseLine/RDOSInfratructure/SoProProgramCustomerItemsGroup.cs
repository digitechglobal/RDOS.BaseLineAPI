using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SoProProgramCustomerItemsGroup
    {
        public Guid Id { get; set; }
        public string? ProgramCustomerItemsGroupCode { get; set; }
        public string? ProgramCustomersDetailCode { get; set; }
        public string? PromotionRefNumber { get; set; }
        public int Quantities { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public string? ItemGroupCode { get; set; }
        public string? Uomcode { get; set; }
        public int FixedQuantities { get; set; }
        public bool IsDeleted { get; set; }
        public int ItemGroupQuantities { get; set; }
        public decimal MinAmt { get; set; }
        public int MinQty { get; set; }
        public string? ProductTypeForSale { get; set; }
        public string? InventoryItemCode { get; set; }
        public string? ItemHierarchyValueForSale { get; set; }
    }
}
