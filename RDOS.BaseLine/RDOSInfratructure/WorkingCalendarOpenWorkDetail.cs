using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarOpenWorkDetail
    {
        public Guid Id { get; set; }
        public string OpenWorkRefNumber { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string JobtitileCode { get; set; }
        public string JobtitileName { get; set; }
        public DateTime WorkingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
