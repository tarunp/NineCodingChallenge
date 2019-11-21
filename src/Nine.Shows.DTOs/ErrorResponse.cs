using System.Text.Json.Serialization;
namespace Nine.Shows.DTOs
{
    public class ErrorResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
