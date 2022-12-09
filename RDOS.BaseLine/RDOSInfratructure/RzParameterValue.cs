using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class RzParameterValue
    {
        public Guid Id { get; set; }
        public string ParameterTypeCode { get; set; }
        public string ParameterSettingCode { get; set; }
        public string Value { get; set; }
        public bool Used { get; set; }
    }
}
