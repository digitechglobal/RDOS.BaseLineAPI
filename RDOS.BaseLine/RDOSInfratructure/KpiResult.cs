using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class KpiResult
    {
        public Guid Id { get; set; }
        public string? SiType { get; set; }
        public string? SiCode { get; set; }
        public string? KpiCode { get; set; }
        public DateTime Date { get; set; }
        public string? SalesWeek { get; set; }
        public string? SalesPeriod { get; set; }
        public string? SalesQuarter { get; set; }
        public string? SalesYear { get; set; }
        public decimal Utd { get; set; }
        public decimal Wtd { get; set; }
        public decimal Mtd { get; set; }
        public decimal Qtd { get; set; }
        public decimal Ytd { get; set; }
        public string? KpiForObjectCode { get; set; }
        public string? ObjectCode { get; set; }
        public string? ObjectType { get; set; }
        public string? Siccode { get; set; }
        public string? SaleOrg { get; set; }
    }
}
