using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempBaselineDetailRequestPo
    {
        public Guid Id { get; set; }
        public string Rpocode { get; set; }
        public string Grpocode { get; set; }
        public string Skucode { get; set; }
        public string UoM { get; set; }
        public int Quantity { get; set; }
        public decimal IntoMoney { get; set; }
        public int Point { get; set; }
    }
}
