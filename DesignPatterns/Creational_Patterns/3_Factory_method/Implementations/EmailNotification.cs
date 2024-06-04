using DesignPatterns.Creational_Patterns._3_Factory_method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._3_Factory_method.Implementations
{
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

}
