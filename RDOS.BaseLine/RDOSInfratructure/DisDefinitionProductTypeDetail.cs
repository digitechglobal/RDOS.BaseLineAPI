using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisDefinitionProductTypeDetail
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string? ItemHierarchyLevel { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Packing { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
