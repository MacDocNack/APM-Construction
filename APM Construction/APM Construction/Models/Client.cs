using System.Text.Json.Serialization;

namespace APM_Construction.Models
{
    public record Client
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }
    }
}
