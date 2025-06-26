using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace APM_Construction_Server.Models
{
    public record Project
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Budget")]
        public decimal Budget { get; set; }
        [JsonPropertyName("IdClient")]
        public int IdClient { get; set; }
        [JsonPropertyName("IdContractor")]
        public int IdContractor { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("State")]
        public string State { get; set; }
        [JsonPropertyName("DateStart")]
        public DateOnly DateStart { get; set; }
        [JsonPropertyName("DateEnd")]
        public DateOnly DateEnd { get; set; }
        [JsonPropertyName("RequiredResources")]
        public ObservableCollection<Resource> RequiredResources { get; set; } = new ObservableCollection<Resource>();
    }
}
