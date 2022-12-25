﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlsettingProcessPending
    {
        public Guid Id { get; set; }
        public string BaselineSettingRef { get; set; } = null!;
        public string? Description { get; set; }
        public string? FromStatus { get; set; }
        public string? ToStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}