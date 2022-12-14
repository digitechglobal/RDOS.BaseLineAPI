using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempBaselineHeaderRequestPo
    {
        public Guid Id { get; set; }
        public string? Rpocode { get; set; }
        public string? Grpocode { get; set; }
        public string? DistributorCode { get; set; }
        public string? DistributorLocationCode { get; set; }
    }
}
