using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisConfirmResult
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string DisplayCode { get; set; } = null!;
        public string SalesCalendarCode { get; set; } = null!;
        public bool IsNumberVisits { get; set; }
        public int? NumberVisitsType { get; set; }
        public int? NumberVisits { get; set; }
        public decimal? PercentPass { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
