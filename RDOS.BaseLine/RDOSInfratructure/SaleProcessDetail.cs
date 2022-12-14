using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SaleProcessDetail
    {
        public Guid Id { get; set; }
        public string? SettingsRefNo { get; set; }
        public string? StepCode { get; set; }
        public int? Order { get; set; }
        public bool? Required { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
