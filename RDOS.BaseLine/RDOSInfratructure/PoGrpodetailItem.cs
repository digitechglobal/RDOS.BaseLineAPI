﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class PoGrpodetailItem
    {
        public Guid Id { get; set; }
        public int ConfirmedQuantity { get; set; }
        public string? DiscountSchemeId { get; set; }
        public int ReceiptQuantity { get; set; }
        public int ReceiptBaseQuantity { get; set; }
        public string? Location { get; set; }
        public string? WareHouse { get; set; }
        public string? Grponumber { get; set; }
        public bool IsFree { get; set; }
        public string? Atrribute1 { get; set; }
        public string? Atrribute2 { get; set; }
        public string? Atrribute3 { get; set; }
        public string? Atrribute4 { get; set; }
        public string? Atrribute5 { get; set; }
        public string? Atrribute6 { get; set; }
        public string? Atrribute7 { get; set; }
        public string? Atrribute8 { get; set; }
        public string? Atrribute9 { get; set; }
        public string? Atrribute10 { get; set; }
        public Guid? Hierarchy { get; set; }
        public string? ItemGroupCode { get; set; }
        public string? ShortName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? Uom { get; set; }
        public int OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Vat { get; set; }
        public string? VatCode { get; set; }
        public string? BaseUom { get; set; }
        public string? WareHouseDescription { get; set; }
        public string? ErpCode { get; set; }
        public string? ItemReportName { get; set; }
    }
}
