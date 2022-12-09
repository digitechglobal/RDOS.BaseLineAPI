using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountObjectCustomerShipto
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerShiptoCode { get; set; }
    }
}
