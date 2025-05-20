using ClimaNaSuaCidade.Services;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json");

var config = builder.Build();
string apiKey = config["ApiSettings:OpenWeatherKey"];

var climaService = new ClimaService(apiKey);

Console.Write("Olá! Qual cidade você deseja saber o clima agora? ");
string? nomeCidade = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nomeCidade))
{
    Console.WriteLine("Nome da cidade não pode ser vazio!");
    return;
}

var clima = await climaService.ObterClimaAsync(nomeCidade);

if (clima == null)
{
    Console.WriteLine("Cidade não encontrada!");
}

Console.WriteLine($"\nClima em {nomeCidade}: ");
Console.WriteLine($"Temperatura: {clima.Main.Temp}°C");
Console.WriteLine($"Umidade: {clima.Main.Humidity}%");
Console.WriteLine($"Descrição: {clima.Weather[0].Description}");