using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisPayReward
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string DisplayCode { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string ConfirmResultDisplayCode { get; set; } = null!;
        public bool PayRewardMethod { get; set; }
    }
}
