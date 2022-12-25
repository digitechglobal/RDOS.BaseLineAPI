using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlConfirmPerformanceDetail
    {
        public Guid Id { get; set; }
        public string? ValueCode { get; set; }
        public string? ValueDescription { get; set; }
        public string ConfirmRef { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
