using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscount
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Scheme { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string SaleOrg { get; set; }
        public string DiscountFrequency { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string ObjectType { get; set; }
        public string ScopeType { get; set; }
        public string FileExt { get; set; }
        public string FolderType { get; set; }
        public int DiscountType { get; set; }
        public string ReasonStep1 { get; set; }
        public string ReasonStep2 { get; set; }
        public string ReasonStep3 { get; set; }
        public string ReasonStep4 { get; set; }
        public string ScopeSaleTerritoryLevel { get; set; }
        public int SettlementFrequency { get; set; }
        public string SicCode { get; set; }
    }
}
