using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ServiceDetail
    {
        public Guid Id { get; set; }
        public Guid EcoServiceId { get; set; }
        public string? Code { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public string? Output { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
