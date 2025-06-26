using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APM_Construction.Models
{
    public record User
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("EmployeeId")]
        public int EmployeeId { get; set; }
        [JsonPropertyName("Login")]
        public string Login { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
        [JsonPropertyName("Role")]
        public string Role { get; set; }
    }
}
