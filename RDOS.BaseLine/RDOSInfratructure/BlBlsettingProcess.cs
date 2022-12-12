using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlBlsettingProcess
    {
        public Guid Id { get; set; }
        public string ProcessCode { get; set; }
        public string BaselineSettingRef { get; set; }
        public int? Priority { get; set; }
        public bool? IsSequentialProcessing { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
