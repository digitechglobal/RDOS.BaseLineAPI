using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class UserPolicy
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PolicyId { get; set; }

        public virtual Policy Policy { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
