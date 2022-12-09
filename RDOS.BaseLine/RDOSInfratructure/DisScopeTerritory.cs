using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisScopeTerritory
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; }
        public string TerritoryStructureCode { get; set; }
        public string SalesTerritoryValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string SaleOrg { get; set; }
        public string SaleTerritoryLevel { get; set; }
    }
}
