﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class InvAdjustmentHeader
    {
        public Guid Id { get; set; }
        public string? AdjustmentNumber { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? SalesPeriod { get; set; }
        public string? DistributorCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
