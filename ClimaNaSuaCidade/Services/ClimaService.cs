using ClimaNaSuaCidade.Models;
using System.Text.Json;

namespace ClimaNaSuaCidade.Services;

internal class ClimaService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public ClimaService(string apiKey)
    {
        _httpClient = new HttpClient();
        _apiKey = apiKey;
    }

    public async Task<ClimaResponse> ObterClimaAsync(string cidade)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={_apiKey}&units=metric&lang=pt_br";

        var resposta = await _httpClient.GetAsync(url);

        if (!resposta.IsSuccessStatusCode) return null;

        var conteudo = await resposta.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<ClimaResponse>(conteudo);
    }
}
