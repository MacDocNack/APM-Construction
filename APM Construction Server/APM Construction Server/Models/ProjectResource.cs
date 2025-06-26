using System.Text.Json.Serialization;

namespace APM_Construction_Server.Models
{
    public record ProjectResource
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("IdProject")]
        public int IdProject { get; set; }
        [JsonPropertyName("IdResource")]
        public int IdResource { get; set; }
        [JsonPropertyName("Amount")]
        public int Amount { get; set; }
    }
}
