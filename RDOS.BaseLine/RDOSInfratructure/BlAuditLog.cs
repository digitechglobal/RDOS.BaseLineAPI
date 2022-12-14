using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlAuditLog
    {
        public Guid Id { get; set; }
        public string BaselineSettingRef { get; set; } = null!;
        public DateTime? BaselineDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string ProcessCode { get; set; } = null!;
        public bool? IsSuccess { get; set; }
        public string? Description { get; set; }
        public DateTime? FinishTime { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
