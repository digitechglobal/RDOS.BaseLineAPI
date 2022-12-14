using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class Container
    {
        public Guid Id { get; set; }
        public string? ContainerName { get; set; }
        public string IpAddress { get; set; } = null!;
        public string Key { get; set; } = null!;
        public int ContainerStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
