using System.Text.Json.Serialization;

namespace APM_Construction_Server.Models
{
    public record User
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("EmployeeId")]
        public int EmployeeId { get; set; }
        [JsonPropertyName("Login")]
        public string Login {  get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
        [JsonPropertyName("Role")]
        public string Role { get; set; }
    }
}
