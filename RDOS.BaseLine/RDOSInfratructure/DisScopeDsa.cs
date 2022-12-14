using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisScopeDsa
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string ScopeDsaValue { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string SaleOrg { get; set; } = null!;
    }
}
