
namespace Pendopo.TraningGame.Message
{
    public struct SetExpireMessage
    {
        public string expireMessage { get; private set; }

        public SetExpireMessage(string expireMessage)
        {
            this.expireMessage = expireMessage;
        }
    }
}