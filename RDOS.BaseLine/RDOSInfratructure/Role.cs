﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class Role
    {
        public Role()
        {
            RoleClaims = new HashSet<RoleClaim>();
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsPrincipal { get; set; }
        public string FeatureAction { get; set; }
        public string DynamicFieldValue { get; set; }

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
