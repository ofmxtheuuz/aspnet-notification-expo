namespace NotificationExpo_API.Controllers.Http.Responses;

public class SendNotificationRequest
{
    public string to { get; set; }
    public string sound { get; set; } = "default";
    public string title { get; set; }
    public string body { get; set; }
}