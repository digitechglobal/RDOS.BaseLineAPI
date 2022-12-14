using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountStructureDetail
    {
        public Guid Id { get; set; }
        public string? DiscountCode { get; set; }
        public int DiscountType { get; set; }
        public string NameDiscountLevel { get; set; } = null!;
        public decimal DiscountCheckValue { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public string? ImagePath { get; set; }
        public string? ImageName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? FileExt { get; set; }
        public string? FolderType { get; set; }
    }
}
