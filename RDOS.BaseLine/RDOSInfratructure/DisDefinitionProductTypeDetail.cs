using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisDefinitionProductTypeDetail
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; }
        public string LevelCode { get; set; }
        public string ProductType { get; set; }
        public string ItemHierarchyLevel { get; set; }
        public string ProductCode { get; set; }
        public string Packing { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
