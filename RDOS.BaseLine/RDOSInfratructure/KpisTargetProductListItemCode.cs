﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class KpisTargetProductListItemCode
    {
        public Guid Id { get; set; }
        public string KpisTargetCode { get; set; }
        public string FrequencyCode { get; set; }
        public string ProductListCode { get; set; }
        public bool IsUsed { get; set; }
        public string ItemCode { get; set; }
        public string FromSalesPeriod { get; set; }
        public string ToSalesPeriod { get; set; }
    }
}
