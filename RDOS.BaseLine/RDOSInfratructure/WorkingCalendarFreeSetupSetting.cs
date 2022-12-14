using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarFreeSetupSetting
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
