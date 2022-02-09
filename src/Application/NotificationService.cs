using UMApplication.Application.Common.Interfaces;
using UMApplication.Application.Notifications.Models;
using System.Threading.Tasks;

namespace UMApplication.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}
