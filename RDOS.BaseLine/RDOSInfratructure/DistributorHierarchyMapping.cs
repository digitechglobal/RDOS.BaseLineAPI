using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DistributorHierarchyMapping
    {
        public Guid Id { get; set; }
        public Guid CustomerAttributeId { get; set; }
        public Guid CustomerSettingHierarchyId { get; set; }
        public Guid DistributorHierarchyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; } = null!;
        public virtual CustomerSettingHierarchy CustomerSettingHierarchy { get; set; } = null!;
        public virtual DistributorHierarchy DistributorHierarchy { get; set; } = null!;
    }
}
