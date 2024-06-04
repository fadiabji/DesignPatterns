using DesignPatterns.Creational_Patterns._3_Factory_method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._3_Factory_method
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public void SendNotification(string message)
        {
            INotification notification = CreateNotification();
            notification.Notify(message);
        }
    }

}
