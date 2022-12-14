﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class RzBeatPlanEmployee
    {
        public Guid Id { get; set; }
        public string? BeatPlanCode { get; set; }
        public string? EmployeeCode { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
