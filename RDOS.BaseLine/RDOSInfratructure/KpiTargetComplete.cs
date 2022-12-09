using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class KpiTargetComplete
    {
        public Guid Id { get; set; }
        public string KpiTargetCode { get; set; }
        public string Frequency { get; set; }
        public int? TotalNumberObject { get; set; }
        public int? TotalNumberObjectTarget { get; set; }
        public bool? IsFinishTarget { get; set; }
    }
}
