using System.Text.Json.Serialization;

namespace APM_Construction_Server.Models
{
    public record Job
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("IdTask")]
        public int IdTask { get; set; }
        [JsonPropertyName("IdEmployee")]
        public int IdEmployee { get; set; }
        [JsonPropertyName("AppointmentDate")]
        public DateTime AppointmentDate { get; set; }
    }
}
