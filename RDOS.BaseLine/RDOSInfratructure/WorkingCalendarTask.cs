using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarTask
    {
        public Guid Id { get; set; }
        public string TaskId { get; set; }
        public string WorkingCalendarCode { get; set; }
        public string WorkingCalendarType { get; set; }
        public string ShiftCode { get; set; }
        public string Session { get; set; }
        public TimeOnly FromTime { get; set; }
        public TimeOnly ToTime { get; set; }
        public int? Priority { get; set; }
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public string WorkingType { get; set; }
        public string CustomerType { get; set; }
        public string WorkingWithObject { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string ShiftName { get; set; }
    }
}
