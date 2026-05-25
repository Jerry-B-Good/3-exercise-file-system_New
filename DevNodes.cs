using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Concept
{
    public class DevFile
    {
        [JsonPropertyName("nodes")]
        public List<DevNode> Nodes { get; set; } = new();
    }

    public class DevNode
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("width")]
        public double Width { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
//         DevNode labels = new DevNode();