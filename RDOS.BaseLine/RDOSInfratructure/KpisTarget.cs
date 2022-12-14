using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class KpisTarget
    {
        public Guid Id { get; set; }
        public string? KpisTargetCode { get; set; }
        public string? KpisTargetType { get; set; }
        public string? SalesOrgCode { get; set; }
        public string? SalesTerritoryStructure { get; set; }
        public string? ObjectCode { get; set; }
    }
}
