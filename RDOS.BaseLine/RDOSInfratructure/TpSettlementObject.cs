using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpSettlementObject
    {
        public Guid Id { get; set; }
        public string SettlementCode { get; set; }
        public string ProgramType { get; set; }
        public string PromotionDiscountCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
