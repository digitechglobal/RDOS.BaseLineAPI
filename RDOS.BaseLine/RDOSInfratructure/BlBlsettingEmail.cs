using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlsettingEmail
    {
        public Guid Id { get; set; }
        public string BaselineSettingRef { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
