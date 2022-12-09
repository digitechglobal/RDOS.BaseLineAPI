using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendar
    {
        public Guid Id { get; set; }
        public string WorkingCalendarCode { get; set; }
        public string RequestType { get; set; }
        public string Type { get; set; }
        public DateTime WorkingDate { get; set; }
        public string PeriodId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string JobtitleCode { get; set; }
        public string JobtitileDescription { get; set; }
        public string SaleOrgCode { get; set; }
        public string SaleOrgDesc { get; set; }
        public string SicCode { get; set; }
        public string SicDescription { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public bool? IsValid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string RequestReason { get; set; }
        public string RejectReason { get; set; }
        public string RequestStatus { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedByName { get; set; }
    }
}
