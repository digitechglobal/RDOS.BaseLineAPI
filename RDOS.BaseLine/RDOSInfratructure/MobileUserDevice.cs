using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class MobileUserDevice
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceId { get; set; }
        /// <summary>
        ///  IMEI hay Serieral của thiết bị
        /// </summary>
        public string? Os { get; set; }
        public string? Osversion { get; set; }
        public Guid? AppId { get; set; }
        public string? AppVersion { get; set; }
        public string? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? UntilDate { get; set; }
    }
}
