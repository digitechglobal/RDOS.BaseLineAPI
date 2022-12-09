using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ApplicationService
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid EcoServiceId { get; set; }
        public Guid EcoVersionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Application Application { get; set; }
        public virtual Service EcoService { get; set; }
        public virtual Version EcoVersion { get; set; }
    }
}
