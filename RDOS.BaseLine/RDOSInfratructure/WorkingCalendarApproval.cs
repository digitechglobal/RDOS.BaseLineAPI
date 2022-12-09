using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarApproval
    {
        public Guid Id { get; set; }
        public string WorkingCalendarCode { get; set; }
        public string RequestType { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string JobtitleCode { get; set; }
        public string JobtitleName { get; set; }
        public DateTime? WorkingDate { get; set; }
        public string Reason { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
