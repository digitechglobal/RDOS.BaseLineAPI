using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlNormOfBussinessModel
    {
        public Guid Id { get; set; }
        public string? SalesPeriod { get; set; }
        public string? BusinessModelId { get; set; }
        public string? BusinessModelDesc { get; set; }
        public string? Siid { get; set; }
        public string? Sidesc { get; set; }
        public string? Value { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
