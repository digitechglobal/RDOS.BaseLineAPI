using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountObjectCustomerAttributeLevel
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; }
        public string CustomerAttributerLevel { get; set; }
        public bool IsApply { get; set; }
    }
}
