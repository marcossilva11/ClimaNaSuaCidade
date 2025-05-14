using System.Text.Json.Serialization;

namespace ClimaNaSuaCidade.Models;

public class ClimaResponse
{
    [JsonPropertyName("main")]
    public MainInfo Main { get; set; }
    [JsonPropertyName("weather")]
    public List<WeatherInfo> Weather { get; set; }
}
