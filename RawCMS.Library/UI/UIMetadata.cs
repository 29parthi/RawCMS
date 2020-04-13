﻿using System.Collections.Generic;

namespace RawCMS.Library.UI
{
    public enum UIResourceRequirementType
    {
        Javascript,
        CSS
    }

    public class UIResourceRequirement
    {
        public UIResourceRequirementType Type { get; set; }
        public string ResourceUrl { get; set; }

        public Dictionary<string, string> CustomAttributes { get; set; } = new Dictionary<string, string>();

        public int Order { get; set; }
    }

    public class UIMetadata
    {
        public List<UIResourceRequirement> Requirements = new List<UIResourceRequirement>();

        public string ModuleUrl { get; set; }
        public string ModuleName { get; set; }
    }
}