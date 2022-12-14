using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class RzVisitFrequency
    {
        public Guid Id { get; set; }
        public string? VisitFrequencyCode { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
    }
}
