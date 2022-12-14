using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ItemAttribute
    {
        public ItemAttribute()
        {
            PrimarySicIncludeDetails = new HashSet<PrimarySicIncludeDetail>();
        }

        public Guid Id { get; set; }
        public string ItemAttributeMaster { get; set; } = null!;
        public string ItemAttributeCode { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntilDate { get; set; }
        public int DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<PrimarySicIncludeDetail> PrimarySicIncludeDetails { get; set; }
    }
}
