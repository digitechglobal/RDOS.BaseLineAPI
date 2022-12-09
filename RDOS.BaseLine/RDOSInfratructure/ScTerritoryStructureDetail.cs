using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ScTerritoryStructureDetail
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public bool IsDeleted { get; set; }
        public string TerritoryStructureCode { get; set; }
        public string TerritoryLevelCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
