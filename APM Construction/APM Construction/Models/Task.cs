using System.Text.Json.Serialization;

namespace APM_Construction.Models
{
    public record Task
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("IdProject")]
        public int IdProject { get; init; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("DateStart")]
        public DateOnly DateStart { get; set; }
        [JsonPropertyName("DateEnd")]
        public DateOnly DateEnd { get; set; }
        [JsonPropertyName("State")]
        public string State { get; set; }
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }
    }
}
