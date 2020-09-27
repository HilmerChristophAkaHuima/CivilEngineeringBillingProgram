using PrismUi.Services.Interfaces;

namespace PrismUi.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
