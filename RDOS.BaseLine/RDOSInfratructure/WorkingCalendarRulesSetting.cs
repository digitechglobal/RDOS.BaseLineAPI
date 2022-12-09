using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarRulesSetting
    {
        public Guid Id { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowFreeSetup { get; set; }
        public bool ApproveByReportingLine { get; set; }
        public bool ApprovedByJobtitle { get; set; }
        public bool SetupFrequenly { get; set; }
        public bool SetupFreely { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
