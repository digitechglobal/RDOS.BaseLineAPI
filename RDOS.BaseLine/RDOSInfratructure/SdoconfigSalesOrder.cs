using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SdoconfigSalesOrder
    {
        public Guid Id { get; set; }
        public string Sdocode { get; set; }
        public string SalesUoMcode { get; set; }
        public int? Value { get; set; }
    }
}
