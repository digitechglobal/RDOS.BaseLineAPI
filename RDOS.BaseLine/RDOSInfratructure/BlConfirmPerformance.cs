using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlConfirmPerformance
    {
        public Guid Id { get; set; }
        public string ConfirmRef { get; set; } = null!;
        public DateTime? ConfirmDate { get; set; }
        public string? ConfirmByUser { get; set; }
        public string? Description { get; set; }
        public string? FileType { get; set; }
        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        public string? SalesOrgCode { get; set; }
        public string? SalesOrgDescription { get; set; }
        public string? Type { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SaleYear { get; set; }
        public string? SalePeriod { get; set; }
        public int? Ordinal { get; set; }
        public DateTime? CalendarStartDate { get; set; }
        public DateTime? CalendarEndDate { get; set; }
    }
}
