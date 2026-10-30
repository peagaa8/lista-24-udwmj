using System.Text.Json.Serialization;

namespace SearchAgentValorantAPI.Models
{
    public class ValorantApiResponse
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("data")]
        public AgentData? Data { get; set; }
    }

    public class AgentData
    {
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("fullPortrait")]
        public string? FullPortrait { get; set; }
    }
}