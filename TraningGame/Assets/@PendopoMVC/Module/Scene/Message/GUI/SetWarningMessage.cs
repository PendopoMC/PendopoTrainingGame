
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
    public struct SetActivetWarningMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetWarningMessage(bool active)
        {
            this.active = active;
        }
    }
}