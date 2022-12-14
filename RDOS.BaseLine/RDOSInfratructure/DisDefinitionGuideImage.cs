﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisDefinitionGuideImage
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? ImageName { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? ImageFileExt { get; set; }
        public string? ImageFolderType { get; set; }
    }
}
