﻿using UMApplication.Application.Common.Interfaces;
using UMApplication.Application.Notifications.Models;
using System.Threading.Tasks;

namespace Northwind.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}
