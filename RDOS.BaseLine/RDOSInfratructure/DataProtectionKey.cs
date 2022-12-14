using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DataProtectionKey
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; } = null!;
        public string Xml { get; set; } = null!;
    }
}
