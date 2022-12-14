using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountObjectCustomerShipto
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string CustomerCode { get; set; } = null!;
        public string CustomerShiptoCode { get; set; } = null!;
    }
}
