using System.Text.Json.Serialization;

namespace ConfluenceTableParser
{
    public class UsageMaterial
    {
        [JsonPropertyName("Group")]
        public string MaterialGroup { get; }

        [JsonPropertyName("Name")]
        public string MaterialTitle { get; }

        [JsonPropertyName("MtrlName")]
        public string MaterialName { get; }

        [JsonPropertyName("Oboznacheniye")]
        public string MaterialNotation { get; }

        [JsonPropertyName("Units")]
        public string MaterialMeasureUnits { get; }

        [JsonPropertyName("Usage")]
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
