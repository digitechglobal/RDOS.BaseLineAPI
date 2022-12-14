using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class NotificationTemplate
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? Data { get; set; }
        public string? Purpose { get; set; }
        public Guid? AppId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsDefault { get; set; }
    }
}
