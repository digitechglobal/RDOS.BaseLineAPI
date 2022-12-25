using RDOS.BaseLine.RDOSInfratructure;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Models.Request
{
    public class ConfirmPerformanceModel
    {
        public DateTime ConfirmDate { get; set; }
        public string? Description { get; set; }
        public string? FileType { get; set; }
        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        public string? SalesOrgCode { get; set; }
        public string? SalesOrgDescription { get; set; }
        public string Type { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public virtual List<ConfirmPerformanceDetailModel> ConfirmPerformanceDetails { get; set; }
        public List<Guid> RawSoIds { get; set; }
    }

    public class ConfirmPerformanceDetailModel
    {
        public string? ValueCode { get; set; }
        public string? ValueDescription { get; set; }
    }

    public class ConfirmPerforamceSearch : EcoParameters
    {

    }

    public class ListonfirmPerforamce
    {
        public List<BlConfirmPerformance> Items { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class ListRawSoNotPerformance
    {
        public List<BlRawSo> Items { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class ConfirmPerDetailModel
    {
        public BlConfirmPerformance ConfirmPerformance { get; set; }
        public virtual List<BlConfirmPerformanceDetail> ConfirmPerformanceDetails { get; set; }
    }

    public class FilterConfirmPer : EcoParameters
    {
        public string SalesOrgCode { get; set; }
        public string Type { get; set; }
        public string ValueCode { get; set; }
    }
}
