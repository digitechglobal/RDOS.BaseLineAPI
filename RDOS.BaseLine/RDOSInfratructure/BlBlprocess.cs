using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlprocess
    {
        public Guid Id { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? Description { get; set; }
        public string LinkApi { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsSequentialProcessing { get; set; }
        public int Priority { get; set; }
    }
}
