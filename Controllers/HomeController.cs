using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NotificationExpo_API.Controllers.Http.Responses;
using NotificationExpo_API.Controllers.Service;

namespace NotificationExpo_API.Controllers;

[Route("v2")]
public class HomeController : Controller
{
    [HttpPost("send/notification")]    
    public async Task<bool> Index([FromBody] SendNotificationRequest req)
    {
        var _s = new SendNotificationService();
        return await _s.SendNotification(req);
    }
}