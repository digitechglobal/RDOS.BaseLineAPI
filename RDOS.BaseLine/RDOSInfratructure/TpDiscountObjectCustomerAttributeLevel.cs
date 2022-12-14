using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountObjectCustomerAttributeLevel
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string CustomerAttributerLevel { get; set; } = null!;
        public bool IsApply { get; set; }
    }
}
