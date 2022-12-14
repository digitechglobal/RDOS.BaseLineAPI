using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisCriteriaEvaluatePictureDisplay
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string CriteriaDescription { get; set; } = null!;
        public string Result { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
