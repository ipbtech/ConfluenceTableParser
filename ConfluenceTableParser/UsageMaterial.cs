using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfluenceTableParser
{
    public class UsageMaterial
    {
        public string MaterialGroup { get; }
        public string MaterialTitle { get; }
        public string MaterialName { get; }
        public string MaterialNotation { get; }
        public string MaterialMeasureUnits { get; }
        public string MaterialUsage { get; }

        public UsageMaterial(string materialGroup, string materialTitle, string materialName, 
            string materialNotation, string materialMeasureUnits, string materialUsage)
        {
            MaterialGroup = materialGroup;
            MaterialTitle = materialTitle;
            MaterialName = materialName;
            MaterialNotation = materialNotation;
            MaterialMeasureUnits = materialMeasureUnits;
            MaterialUsage = materialUsage;
        }
    }
}
