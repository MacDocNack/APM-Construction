using System.Text.Json.Serialization;

namespace APM_Construction.Models
{
    public record Employee
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Position")]
        public string Position { get; set; }
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }
        [JsonPropertyName("Salary")]
        public decimal Salary { get; set; }
    }
}
