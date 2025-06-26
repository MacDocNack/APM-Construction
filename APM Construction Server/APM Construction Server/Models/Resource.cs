using System.Text.Json.Serialization;

namespace APM_Construction_Server.Models
{
    public record Resource
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Unit")]
        public string Unit { get; set; }
        [JsonPropertyName("PriceForUnit")]
        public decimal PriceForUnit { get; set; }
    }
}
