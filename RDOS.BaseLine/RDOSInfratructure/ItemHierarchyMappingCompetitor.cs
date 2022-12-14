using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ItemHierarchyMappingCompetitor
    {
        public Guid Id { get; set; }
        public int NodeId { get; set; }
        public Guid CompetitorId { get; set; }
        public int DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
