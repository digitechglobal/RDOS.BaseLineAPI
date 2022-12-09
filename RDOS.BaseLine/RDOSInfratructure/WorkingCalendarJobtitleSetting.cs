using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarJobtitleSetting
    {
        public Guid Id { get; set; }
        public string JobTitleCode { get; set; }
        public string JobTitleName { get; set; }
        public string WorkingCalendarTypeCode { get; set; }
        public string WorkingCalendarTypeValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
