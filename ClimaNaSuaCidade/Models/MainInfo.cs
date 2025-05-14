using System.Text.Json.Serialization;

namespace ClimaNaSuaCidade.Models
{
    public class MainInfo
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }
}