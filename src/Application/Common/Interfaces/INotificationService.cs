using UMApplication.Application.Notifications.Models;
using System.Threading.Tasks;

namespace UMApplication.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
    }
}
