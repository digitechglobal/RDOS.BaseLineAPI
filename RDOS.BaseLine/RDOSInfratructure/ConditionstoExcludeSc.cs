using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ConditionstoExcludeSc
    {
        public Guid Id { get; set; }
        public string SirefCode { get; set; }
        public string ParameterCode { get; set; }
        public string DescriptionCode { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string Reason { get; set; }
        public bool? IsDelete { get; set; }
    }
}
