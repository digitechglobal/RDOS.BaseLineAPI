using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlConfirmPerformanceRawSo
    {
        public Guid Id { get; set; }
        public Guid RowSoId { get; set; }
        public string ConfirmRef { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
