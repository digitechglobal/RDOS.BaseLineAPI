using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class UserType
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string? Name { get; set; }
    }
}
