using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempEvaluationPhotoVisit
    {
        public Guid Id { get; set; }
        public string VisitCode { get; set; }
        public string CustomerCode { get; set; }
        public string InventoryItem { get; set; }
        public string NumberOfInventoryPresent { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime InventoryDate { get; set; }
    }
}
