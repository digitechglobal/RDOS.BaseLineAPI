using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class InventoryKit
    {
        public Guid Id { get; set; }
        public string InventoryItemId { get; set; } = null!;
        public bool? NonStock { get; set; }
        public string KitDescription { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string StockItem { get; set; } = null!;
        public int Quantity { get; set; }
        public string Uom { get; set; } = null!;
        public bool? Vat { get; set; }
        public string NonStockItem { get; set; } = null!;
        public bool NonQuantity { get; set; }
        public bool NonUom { get; set; }
    }
}
