using RDOS.BaseLine.RDOSInfratructure;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Models.Request
{
    public class ConfirmPerformanceModel
    {
        public Guid? Id { get; set; }
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
        public bool IsConfirm { get; set; } = false;
        public int? SaleYear { get; set; }
        public string? SalePeriod { get; set; }
        public int? Ordinal { get; set; }
        public DateTime? CalendarStartDate { get; set; }
        public DateTime? CalendarEndDate { get; set; }
    }

    public class ConfirmPerformanceDetailModel
    {
        public Guid? Id { get; set; }
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
        public List<RawSoModel> Items { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class ConfirmPerDetailModel
    {
        public BlConfirmPerformance ConfirmPerformance { get; set; }
        public virtual List<BlConfirmPerformanceDetail> ConfirmPerformanceDetails { get; set; }
        public virtual List<RawSoModel> ListRowSo { get; set; }
    }

    public class FilterConfirmPer : EcoParameters
    {
        public string SalesOrgCode { get; set; }
        public string Type { get; set; }
        public List<string> ValueCode { get; set; }
    }

    public class RawSoModel
    {
        public Guid Id { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? OrderRefNumber { get; set; }
        public string? Status { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerShiptoId { get; set; }
        public string? CustomerShiptoName { get; set; }
        public string? Dsaid { get; set; }
        public string? Dsadesc { get; set; }
        public string? RouteZoneId { get; set; }
        public string? RouteZoneDesc { get; set; }
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? SubRegionId { get; set; }
        public string? SubRegionName { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? SubAreaId { get; set; }
        public string? SubAreaName { get; set; }
        public string? SalesOrgId { get; set; }
        public DateTime BaselineDate { get; set; }
    }
}
