using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SoProProgramCustomer
    {
        public Guid Id { get; set; }
        public string? ProgramCustomersKey { get; set; }
        public string? ProgramCode { get; set; }
        public string? ProgramsType { get; set; }
        public string? ProgramsDescription { get; set; }
        public string? ProgramsItemScope { get; set; }
        public string? CustomerCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string? ShiptoCode { get; set; }
        public string? ShiptoAttribute1 { get; set; }
        public string? ShiptoAttribute10 { get; set; }
        public string? ShiptoAttribute2 { get; set; }
        public string? ShiptoAttribute3 { get; set; }
        public string? ShiptoAttribute4 { get; set; }
        public string? ShiptoAttribute5 { get; set; }
        public string? ShiptoAttribute6 { get; set; }
        public string? ShiptoAttribute7 { get; set; }
        public string? ShiptoAttribute8 { get; set; }
        public string? ShiptoAttribute9 { get; set; }
        public string PromotionRefNumber { get; set; } = null!;
    }
}
