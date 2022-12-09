using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class ItemsFile
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string FileCreatedDateStr { get; set; }
        public string FileExt { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FolderType { get; set; }
    }
}
