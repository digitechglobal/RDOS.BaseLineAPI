﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TemporarySic
    {
        public TemporarySic()
        {
            TemporarySicItemGroupDetails = new HashSet<TemporarySicItemGroupDetail>();
            TemporarySicKitDetails = new HashSet<TemporarySicKitDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int? DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<TemporarySicItemGroupDetail> TemporarySicItemGroupDetails { get; set; }
        public virtual ICollection<TemporarySicKitDetail> TemporarySicKitDetails { get; set; }
    }
}
