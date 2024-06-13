using System.Text.Json;
using System.Text.Json.Serialization;

namespace Super_Advanced_Super_Cool.Models
{
    public class AnimalImage
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}
