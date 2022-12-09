using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarTaskApplySetting
    {
        public Guid Id { get; set; }
        public string TaskCode { get; set; }
        public string TaskDescription { get; set; }
        public string JobtitileCode { get; set; }
        public string JobtitleName { get; set; }
        public bool CoordinateRequired { get; set; }
        public float? Distance { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool Used { get; set; }
    }
}
