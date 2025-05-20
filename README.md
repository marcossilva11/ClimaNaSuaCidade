# ☀️ Clima na Sua Cidade – C# + .NET

Um aplicativo de console desenvolvido em **C# com .NET**, que permite ao usuário **consultar a previsão do tempo** de qualquer cidade do mundo, utilizando a **API OpenWeatherMap**.

Ao iniciar o programa, o usuário informa o nome da cidade e, em poucos segundos, recebe dados sobre **temperatura, umidade e descrição do clima atual**.

---

## 💡 Funcionalidades

✅ Consulta de clima em tempo real para qualquer cidade.  
✅ Exibição de temperatura, umidade e descrição do tempo.  
✅ Interface amigável via terminal.  
✅ Código modular com aplicação de POO.  
✅ Integração com Web API via HttpClient.  
✅ Leitura de configuração externa via appsettings.json.  

---

## 🚀 Como Executar

1. **Clone este repositório:**

   ```bash
   git clone https://github.com/marcossilva11/ClimaNaSuaCidade.git
   ```

2. **Acesse a pasta do projeto:**

   ```bash
   cd ClimaNaSuaCidade
   ```

3. **Crie o arquivo de configuração (veja seção abaixo).**

4. **Restaure os pacotes (se necessário):**

   ```bash
   dotnet restore
   ```

5. **Compile e execute o projeto:**

   ```bash
   dotnet run --project ClimaNaSuaCidade
   ```

---

## ⚙️ Configuração da API

Este projeto utiliza a [API OpenWeatherMap](https://openweathermap.org/api) para obter dados climáticos. Para funcionar corretamente, é necessário fornecer uma **chave de API**.

1. Crie um arquivo chamado `appsettings.Development.json` na raiz do projeto.
2. Copie o conteúdo do arquivo de exemplo `appsettings.example.json` para ele.
3. Insira sua chave da API no campo correspondente:

```json
{
  "ApiSettings": {
    "OpenWeatherKey": "CHAVE-API"
  }
}
```

> ⚠️ **Importante**: o arquivo `appsettings.Development.json` está incluído no `.gitignore` por segurança e **não será versionado no GitHub**. Por isso, é necessário criá-lo manualmente.

---

## 🧰 Tecnologias e Bibliotecas Utilizadas

* **C# e .NET 8**
* **HttpClient** – Para realizar requisições HTTP à API.
* **System.Text.Json** – Para desserializar o JSON retornado pela API.
* **Microsoft.Extensions.Configuration** – Para ler configurações do arquivo `appsettings.json`.

---

## 🧠 Conceitos Utilizados

* **Programação Orientada a Objetos (POO)** – Com uso de classes, propriedades e injeção de dependências.
* **Tratamento de erros** – Verificação de status da resposta HTTP e mensagens amigáveis ao usuário.
* **Async/Await** – Requisições assíncronas para não travar o terminal durante chamadas externas.

---

📌 **Contribuições são bem-vindas!**
Abra um Pull Request ou envie sugestões para melhorar o projeto.
