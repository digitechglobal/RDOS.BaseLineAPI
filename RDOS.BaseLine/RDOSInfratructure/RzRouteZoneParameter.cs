﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class RzRouteZoneParameter
    {
        public Guid Id { get; set; }
        public string ParameterSettingCode { get; set; }
        public string RouteZoneCode { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSpecific { get; set; }
        public string RouteZoneType { get; set; }
        public string Status { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}
