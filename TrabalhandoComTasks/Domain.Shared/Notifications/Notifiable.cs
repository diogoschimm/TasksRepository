using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComTasks.Domain.Shared.Notifications
{
    public class Notifiable
    {
        private IList<string> _notifications;

        public bool IsValid
        {
            get => this._notifications.Count == 0;
        }

        public Notifiable()
        {
            this._notifications = new List<string>();
        }

        public void AddNotification(string message)
        {
            this._notifications.Add(message);
        }
    }
}
