
namespace Pendopo.TraningGame.Message
{
    public struct SetMassMessage
    {
        public string massMessage { get; private set; }

        public SetMassMessage(string massMessage)
        {
            this.massMessage = massMessage;
        }
    }
}