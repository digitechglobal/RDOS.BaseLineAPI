using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class MobileFeaturesPermission
    {
        public Guid Id { get; set; }
        public Guid FeatureId { get; set; }
        public Guid RoleId { get; set; }
        public string Permission { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Order { get; set; }
        public bool ShowHomeScreen { get; set; }
    }
}
