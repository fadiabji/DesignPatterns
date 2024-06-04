using DesignPatterns.Creational_Patterns._3_Factory_method.Interfaces;

namespace DesignPatterns.Creational_Patterns._3_Factory_method.Implementations
{
    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

}
