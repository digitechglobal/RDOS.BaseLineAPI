using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempDisConfirmResultDetail
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string DisplayLevelCode { get; set; } = null!;
        public string DisplayLevelName { get; set; } = null!;
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public bool? IsCheckSalesOutput { get; set; }
        public int SalesOutput { get; set; }
        public bool? IndependentDisplay { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public decimal SalesRegistered { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public decimal OutputRegistered { get; set; }
        public string? PeriodCode { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerShiptoCode { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public int NumberMustRating { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public int NumberHasEvaluate { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public int NumberPassed { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public decimal SalesPass { get; set; }
        /// <summary>
        /// Trường này không cần
        /// </summary>
        public decimal OutputPass { get; set; }
        public bool Result { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitId { get; set; } = null!;
    }
}
