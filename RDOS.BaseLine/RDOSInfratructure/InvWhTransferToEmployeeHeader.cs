﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class InvWhTransferToEmployeeHeader
    {
        public Guid Id { get; set; }
        public string TransferCode { get; set; }
        public DateTime? TransferDate { get; set; }
        public string SalesPeriod { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string DistributorCode { get; set; }
        public string WareHouseCode { get; set; }
        public string EmployeeCode { get; set; }
        public string Emplocation { get; set; }
        public string Description { get; set; }
        public string ReferenceNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
