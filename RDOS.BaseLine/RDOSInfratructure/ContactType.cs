﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ContactType
    {
        public Guid Id { get; set; }
        public Guid ContactId { get; set; }
        public Guid TypeId { get; set; }
        public string ItemTypeCode { get; set; }
        public string TypeCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Hobbies { get; set; }
    }
}
