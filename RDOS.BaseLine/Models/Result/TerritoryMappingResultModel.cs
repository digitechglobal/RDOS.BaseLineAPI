namespace RDOS.BaseLine.Models.Result
{
    public class TerritoryMappingResultModel
    {
        public Guid Id { get; set; }
        public string? MappingNode { get; set; }
        public string? TerritoryValueKey { get; set; }
        public string? ParentMappingNode { get; set; }
        public string? TerritoryStructureCode { get; set; }
        public int Level { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? UntilDate { get; set; }
    }
}
