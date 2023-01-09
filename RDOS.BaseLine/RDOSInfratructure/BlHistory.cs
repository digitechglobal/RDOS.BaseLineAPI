using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlHistory
    {
        public Guid Id { get; set; }
        public string? BaselineSettingRef { get; set; }
        public DateTime BaselineDate { get; set; }
        public string? SalesPeriod { get; set; }
        public DateTime StartTimeDate { get; set; }
        public DateTime EndTimeDate { get; set; }
        public bool IsCompleted { get; set; }
        public string? Type { get; set; }
        public string? Scope { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? SalesOrgId { get; set; }
        public string? SalesOrgDesc { get; set; }
    }
}
