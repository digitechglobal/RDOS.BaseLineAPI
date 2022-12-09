using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisPayReward
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string DisplayCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string ConfirmResultDisplayCode { get; set; }
        public bool PayRewardMethod { get; set; }
    }
}
