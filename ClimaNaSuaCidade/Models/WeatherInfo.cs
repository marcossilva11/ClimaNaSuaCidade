using System.Text.Json.Serialization;

namespace ClimaNaSuaCidade.Models
{
    public class WeatherInfo
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}