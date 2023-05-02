using NotificationExpo_API.Controllers.Http.Responses;

namespace NotificationExpo_API.Controllers.Service.Interfaces;

public interface ISendNotificationService
{
    public Task<bool> SendNotification(SendNotificationRequest req);
}