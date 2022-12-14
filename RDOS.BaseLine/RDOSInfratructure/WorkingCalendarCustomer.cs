using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class WorkingCalendarCustomer
    {
        public Guid Id { get; set; }
        public string? TaskId { get; set; }
        public string? WorkingCalendarCode { get; set; }
        public int Priority { get; set; }
        public string? CustomerAttribute { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? ShiptoId { get; set; }
        public string? ShiptoFullAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
