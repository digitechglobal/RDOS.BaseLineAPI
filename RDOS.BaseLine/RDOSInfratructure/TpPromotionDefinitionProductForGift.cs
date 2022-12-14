using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpPromotionDefinitionProductForGift
    {
        public Guid Id { get; set; }
        public string PromotionCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string Packing { get; set; } = null!;
        public int NumberOfGift { get; set; }
        public string? BudgetCode { get; set; }
        public bool IsDefaultProduct { get; set; }
        public int Exchange { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? ItemHierarchyLevelForGift { get; set; }
        public string? ProductTypeForGift { get; set; }
    }
}
