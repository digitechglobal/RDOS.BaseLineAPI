using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempVisitStepsReasonResult
    {
        public Guid Id { get; set; }
        public string ReasonCode { get; set; }
        public string Module { get; set; }
        public string VisitStepsReasonResultDescription { get; set; }
    }
}
