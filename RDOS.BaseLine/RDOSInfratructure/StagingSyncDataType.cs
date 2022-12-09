using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class StagingSyncDataType
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string RequestType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
