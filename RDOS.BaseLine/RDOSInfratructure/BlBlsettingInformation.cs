using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlsettingInformation
    {
        public Guid Id { get; set; }
        public string SettingRef { get; set; } = null!;
        public string? Description { get; set; }
        public int? LeadDate { get; set; }
        public int? MonthlyBaselineDate { get; set; }
        public bool? IsProcessPendingData { get; set; }
        public string? ProcessPendingTime { get; set; }
        public string? ProcessTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
