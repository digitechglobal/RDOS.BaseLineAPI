using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisApproveRegistrationCustomer
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public DateTime? AdditionalRegistrationDate { get; set; }
        public string? AdditionalReasons { get; set; }
        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        public string? EffectiveTime { get; set; }
        public string? AdditionalAccount { get; set; }
        public string? FileExt { get; set; }
        public string? FolderType { get; set; }
    }
}
