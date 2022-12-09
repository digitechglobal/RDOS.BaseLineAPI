using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempBeatPlanDetail
    {
        public Guid Id { get; set; }
        public Guid BeatPlanId { get; set; }
        public Guid CustomerShiptoId { get; set; }
    }
}
