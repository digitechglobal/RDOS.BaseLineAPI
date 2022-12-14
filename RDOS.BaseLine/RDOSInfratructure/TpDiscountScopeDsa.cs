using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountScopeDsa
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string SaleOrg { get; set; } = null!;
        public string ScopeDsaValue { get; set; } = null!;
    }
}
