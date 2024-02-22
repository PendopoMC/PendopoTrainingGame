
namespace Pendopo.TraningGame.Message
{
    public struct SetWarningMessage : ISetMessage
    {
        public SetWarningMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}