﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class KpivisitFrequency
    {
        public Guid Id { get; set; }
        public Guid KpisettingId { get; set; }
        public string BusinessModel { get; set; } = null!;
        public int VisitFrequency { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
