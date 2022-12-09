using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisDisplay
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Status { get; set; }
        public string SaleOrg { get; set; }
        public string TerritoryStructureCode { get; set; }
        public string SicCode { get; set; }
        public string FrequencyDisplay { get; set; }
        public string Image1Path { get; set; }
        public string Image1Name { get; set; }
        public string Image2Path { get; set; }
        public string Image2Name { get; set; }
        public string Image3Path { get; set; }
        public string Image3Name { get; set; }
        public string Image4Path { get; set; }
        public string Image4Name { get; set; }
        public string ScopeType { get; set; }
        public string ScopeSaleTerritoryLevel { get; set; }
        public string ApplicableObjectType { get; set; }
        public bool? IsCheckSalesOutput { get; set; }
        public int SalesOutput { get; set; }
        public bool? IndependentDisplay { get; set; }
        public bool? ToolDisplay { get; set; }
        public bool? ManageNumberRegister { get; set; }
        public DateTime? RegistrationStartDate { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public bool? IsOverbudget { get; set; }
        public DateTime? ImplementationStartDate { get; set; }
        public DateTime? ImplementationEndDate { get; set; }
        public DateTime? ProgramCloseDate { get; set; }
        public string ReasonCloseProgram { get; set; }
        public string FilePathReasonCloseProgram { get; set; }
        public string FileNameReasonCloseProgram { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string FileExtReasonCloseProgram { get; set; }
        public string FolderTypeReasonCloseProgram { get; set; }
        public string Image1FileExt { get; set; }
        public string Image1FolderType { get; set; }
        public string Image2FileExt { get; set; }
        public string Image2FolderType { get; set; }
        public string Image3FileExt { get; set; }
        public string Image3FolderType { get; set; }
        public string Image4FileExt { get; set; }
        public string Image4FolderType { get; set; }
    }
}
