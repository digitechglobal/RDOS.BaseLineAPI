﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class VvrefResult
    {
        public Guid Id { get; set; }
        public string? Sitype { get; set; }
        public string? Sicode { get; set; }
        public DateTime CalculatorTime { get; set; }
        public string? SalesmanCode { get; set; }
        public string? CustomerCode { get; set; }
        public string? DistributorCode { get; set; }
        public string? VisitCode { get; set; }
        public DateTime VisitDate { get; set; }
        public string? VisitStepResult { get; set; }
        public int VisitDuration { get; set; }
        public bool Result { get; set; }
        public string? SalesOrgCode { get; set; }
        public string? SalesTerritoryCode { get; set; }
        public string? CountryCode { get; set; }
        public string? BranchCode { get; set; }
        public string? RegionCode { get; set; }
        public string? SubRegionCode { get; set; }
        public string? AreaCode { get; set; }
        public string? SubAreaCode { get; set; }
        public string? Dsacode { get; set; }
        public string? RouteZoneCode { get; set; }
        public string? SalesPeriodCode { get; set; }
        public string? SalesWeekCode { get; set; }
        public string? Siccode { get; set; }
    }
}
