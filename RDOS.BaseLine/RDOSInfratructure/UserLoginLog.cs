﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class UserLoginLog
    {
        public Guid Id { get; set; }
        public string UserInfo { get; set; }
        public string UserName { get; set; }
        public int Status { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public string Ip { get; set; }
        public string Agent { get; set; }
        public string Message { get; set; }
        public bool IsStillOnline { get; set; }
        public bool IsDefault { get; set; }
    }
}
