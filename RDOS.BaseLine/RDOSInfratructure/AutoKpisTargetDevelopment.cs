﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class AutoKpisTargetDevelopment
    {
        public Guid Id { get; set; }
        public string AutoKpisTargetCode { get; set; }
        public string BusinessModel { get; set; }
        public decimal? Value { get; set; }
        public decimal? BaseValue { get; set; }
        public string TerritoryValueBySource { get; set; }
    }
}
