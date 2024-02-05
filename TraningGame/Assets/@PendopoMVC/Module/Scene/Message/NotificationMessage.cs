
namespace Pendopo.TraningGame.Message
{
    public struct NotificationMessage 
    {
        public string notificationText { get; private set; }

        public NotificationMessage(string notificationText)
        {
            this.notificationText = notificationText;
        }
    }
}