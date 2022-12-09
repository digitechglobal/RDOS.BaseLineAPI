using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisCustomerAttributeValue
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; }
        public string CustomerAttributerLevel { get; set; }
        public string CustomerAttributerValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
