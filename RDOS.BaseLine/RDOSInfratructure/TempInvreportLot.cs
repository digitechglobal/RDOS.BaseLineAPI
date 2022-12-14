﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempInvreportLot
    {
        public Guid Id { get; set; }
        public string? DistributorCode { get; set; }
        public string? LocationCode { get; set; }
        public string? WareHouseCode { get; set; }
        public string? ItemCode { get; set; }
        public DateTime ReportDate { get; set; }
        public int EndQty { get; set; }
        public string? Lot { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Description { get; set; }
        public string? ItemKey { get; set; }
        public string? Uom { get; set; }
    }
}
