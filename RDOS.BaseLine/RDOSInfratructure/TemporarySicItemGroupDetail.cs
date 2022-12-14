using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TemporarySicItemGroupDetail
    {
        public Guid Id { get; set; }
        public Guid TemporarySicId { get; set; }
        public Guid ItemGroupId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TemporarySic TemporarySic { get; set; }
    }
}
