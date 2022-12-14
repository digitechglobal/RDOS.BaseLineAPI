using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class PrimarySic
    {
        public PrimarySic()
        {
            PrimarySicExcludeHierarchyDetails = new HashSet<PrimarySicExcludeHierarchyDetail>();
            PrimarySicExcludeItemGroupDetails = new HashSet<PrimarySicExcludeItemGroupDetail>();
            PrimarySicIncludeDetails = new HashSet<PrimarySicIncludeDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public Guid GroupByHierarchyLevelId { get; set; }
        public bool IsIncludeProduct { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<PrimarySicExcludeHierarchyDetail> PrimarySicExcludeHierarchyDetails { get; set; }
        public virtual ICollection<PrimarySicExcludeItemGroupDetail> PrimarySicExcludeItemGroupDetails { get; set; }
        public virtual ICollection<PrimarySicIncludeDetail> PrimarySicIncludeDetails { get; set; }
    }
}
