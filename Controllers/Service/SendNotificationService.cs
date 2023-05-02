using NotificationExpo_API.Controllers.Http.Responses;
using NotificationExpo_API.Controllers.Service.Interfaces;
using System.Text;
using System.Text.Json;

namespace NotificationExpo_API.Controllers.Service;


public class SendNotificationService : ISendNotificationService
{
    private readonly string url = "https://exp.host/--/api/v2/push/send";
    
    public async Task<bool> SendNotification(SendNotificationRequest req)
    {
        var headers = new Dictionary<string, string>
        {
            { "Accept-encoding", "gzip, deflate" }
        };

        string JSONBody = JsonSerializer.Serialize(req);
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Clear();

        // Adiciona os cabeçalhos na requisição
        foreach (var header in headers)
        {
            httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        // Cria o conteúdo da requisição
        var content = new StringContent(JSONBody, Encoding.UTF8, "application/json");

        // Faz a requisição POST
        var response = await httpClient.PostAsync(this.url, content);

        // Verifica se a requisição foi bem-sucedida
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Requisição bem-sucedida!");
            return true;
        }
        else
        {
            Console.WriteLine($"Erro: {response.StatusCode}");
            return false;
        }
    }
}