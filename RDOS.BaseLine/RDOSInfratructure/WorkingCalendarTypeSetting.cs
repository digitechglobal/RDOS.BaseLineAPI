using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarTypeSetting
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public bool Used { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
