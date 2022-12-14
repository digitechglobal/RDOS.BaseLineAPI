using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempProgramCustomersDetail
    {
        public Guid Id { get; set; }
        public string ProgramCustomersDetailCode { get; set; }
        public string ProgramCustomersKey { get; set; }
        public string ProgramDetailsKey { get; set; }
        public string PromotionRefNumber { get; set; }
        public int ActualQantities { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public int RemainQuantities { get; set; }
        public int SuggestQantities { get; set; }
        public string DetailLevel { get; set; }
        public string DetailDescription { get; set; }
        public string DetailType { get; set; }
        public int DetailQuantities { get; set; }
        public decimal DetailAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsDeleted { get; set; }
        public decimal ProportionByQuantity { get; set; }
        public string ProgramsBuyType { get; set; }
        public string ProgramsGivingType { get; set; }
    }
}
