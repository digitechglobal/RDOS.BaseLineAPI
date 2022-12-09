using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class AutoKpisTargetDevelopmentDetail
    {
        public Guid Id { get; set; }
        public Guid AutoKpisTargetDevelopmentId { get; set; }
        public string SalePeriod { get; set; }
        public decimal? Value { get; set; }
    }
}
