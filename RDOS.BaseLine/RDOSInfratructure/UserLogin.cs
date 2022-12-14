using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class UserLogin
    {
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public string? ProviderDisplayName { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
