using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ProductList
    {
        public Guid Id { get; set; }
        public string? ProductListCode { get; set; }
        public string? ProductListDescription { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
