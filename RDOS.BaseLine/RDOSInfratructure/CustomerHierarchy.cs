using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class CustomerHierarchy
    {
        public CustomerHierarchy()
        {
            CustomerHierarchyMappings = new HashSet<CustomerHierarchyMapping>();
        }

        public Guid Id { get; set; }
        public int NodeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<CustomerHierarchyMapping> CustomerHierarchyMappings { get; set; }
    }
}
