﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempBaselineDataOrderDetail
    {
        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public string InventoryCode { get; set; }
        public string UoM { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? IsFree { get; set; }
        public decimal? Discount { get; set; }
        public decimal? UnitRate { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Volumne { get; set; }
        public decimal? OrigOrdLineExtendAmt { get; set; }
        public decimal? Point { get; set; }
        public decimal? ShippedBaseQty { get; set; }
        public decimal? OriginalBaseQty { get; set; }
        public decimal? ShippedLineExtendAmt { get; set; }
        public decimal? OrdLineAmt { get; set; }
        public decimal? OrigOrdLineAmt { get; set; }
    }
}
