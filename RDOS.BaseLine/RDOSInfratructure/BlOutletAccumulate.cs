﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlOutletAccumulate
    {
        public Guid Id { get; set; }
        public DateTime BaselineDate { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerShiptoId { get; set; }
        public string? CustomerShiptoName { get; set; }
        public string? TmkprogramType { get; set; }
        public string? TmkprogramId { get; set; }
        public string? TmkprogramDesc { get; set; }
        public string? FrequencyType { get; set; }
        public string? FrequnecyValue { get; set; }
        public string? TmkprogramLevelId { get; set; }
        public string? TmkprogramLevelDesc { get; set; }
        public string? AccumulateType { get; set; }
        public int AccuByProgTarget { get; set; }
        public int AccuByProgActual { get; set; }
        public int AccuByProgProgress { get; set; }
        public string? ProductType { get; set; }
        public string? AccuProductId { get; set; }
        public string? AccuProductDesc { get; set; }
        public string? AccuByProdTarget { get; set; }
        public string? AccuByProdTargetUom { get; set; }
        public int AccuByProdActual { get; set; }
        public string? AccuByProdActualUom { get; set; }
        public int AccuByProdProgress { get; set; }
        public string? AccuWeightType { get; set; }
        public string? AccuWeighProductId { get; set; }
        public string? AccuWeighProductDesc { get; set; }
        public int AccuWeightByProgTarget { get; set; }
        public string? AccuWeightByProgTargetUom { get; set; }
        public int AccuWeightByProgActual { get; set; }
        public string? AccuWeightByProgActualUom { get; set; }
        public int AccuWeightByProgProgress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
