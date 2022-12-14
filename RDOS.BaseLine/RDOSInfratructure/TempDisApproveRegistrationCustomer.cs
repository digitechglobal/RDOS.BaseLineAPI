using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempDisApproveRegistrationCustomer
    {
        public Guid Id { get; set; }
        public string? DisplayCode { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? DisplayLevelName { get; set; }
        public string? DisplayLevelCode { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerShipToCode { get; set; }
        public string? Status { get; set; }
        public string? AreaCode { get; set; }
        public string? BranchCode { get; set; }
        public string? DsaCode { get; set; }
        public string? RegionCode { get; set; }
        public string? SubAreaCode { get; set; }
        public string? SubRegionCode { get; set; }
        public bool ImageReviewResult { get; set; }
    }
}
