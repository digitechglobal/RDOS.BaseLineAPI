using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlsettingTransactionStatus
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsSalesOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
