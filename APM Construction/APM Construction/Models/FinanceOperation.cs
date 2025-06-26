using System.Text.Json.Serialization;

namespace APM_Construction.Models
{
    public record FinanceOperation
    {
        [JsonPropertyName("Id")]
        public int Id { get; init; }
        [JsonPropertyName("IdProject")]
        public int IdProject { get; set; }
        [JsonPropertyName("OperationType")]
        public string OperationType { get; set; }
        [JsonPropertyName("OperationSum")]
        public decimal OperationSum { get; set; }
        [JsonPropertyName("OperationDate")]
        public DateTime OperationDate { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}
