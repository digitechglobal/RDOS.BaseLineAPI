using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpPromotionDefinitionProductForSale
    {
        public Guid Id { get; set; }
        public string PromotionCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? Packing { get; set; }
        public int SellNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? ItemHierarchyLevelForSale { get; set; }
        public string? ProductTypeForSale { get; set; }
    }
}
