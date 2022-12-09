using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SystemLog
    {
        public Guid Id { get; set; }
        public string ObjectName { get; set; }
        public int ErrorCode { get; set; }
        public int LogLevel { get; set; }
        public string Message { get; set; }
        public DateTime LogTime { get; set; }
    }
}
