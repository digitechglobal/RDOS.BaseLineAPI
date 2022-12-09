using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisConfirmResultDetail
    {
        public Guid Id { get; set; }
        public string DisConfirmResultCode { get; set; }
        public string DisplayCode { get; set; }
        public string DisplayLevelCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerShiptoCode { get; set; }
        public int NumberMustRating { get; set; }
        public int NumberHasEvaluate { get; set; }
        public int NumberPassed { get; set; }
        public decimal SalesPass { get; set; }
        public decimal OutputPass { get; set; }
        public bool DisplayImageResult { get; set; }
        public string DisplayImageResultDes { get; set; }
        public bool DisplaySalesResult { get; set; }
        public string DisplaySalesResultDes { get; set; }
        public bool AssessmentPeriodResult { get; set; }
        public string AssessmentPeriodResultDes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
