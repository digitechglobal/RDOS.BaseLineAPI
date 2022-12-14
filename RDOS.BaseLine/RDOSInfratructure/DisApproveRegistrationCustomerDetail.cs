using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisApproveRegistrationCustomerDetail
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string CustomerCode { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerShipToCode { get; set; } = null!;
        public string DisplayLevel { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? AccountReject { get; set; }
        public bool ImageReviewResult { get; set; }
        public string? ReasonReject { get; set; }
        public DateTime? RejectDate { get; set; }
        public string? RejectFileName { get; set; }
        public string? RejectFilePath { get; set; }
        public Guid ApproveRegistrationId { get; set; }
        public string? RejectFileExt { get; set; }
        public string? RejectFolderType { get; set; }
    }
}
