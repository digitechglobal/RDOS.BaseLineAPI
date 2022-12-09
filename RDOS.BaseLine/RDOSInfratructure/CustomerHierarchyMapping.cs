﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class CustomerHierarchyMapping
    {
        public Guid Id { get; set; }
        public Guid CustomerAttributeId { get; set; }
        public Guid CustomerSettingHierarchyId { get; set; }
        public Guid CustomerHierarchyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
        public virtual CustomerHierarchy CustomerHierarchy { get; set; }
        public virtual CustomerSettingHierarchy CustomerSettingHierarchy { get; set; }
    }
}
