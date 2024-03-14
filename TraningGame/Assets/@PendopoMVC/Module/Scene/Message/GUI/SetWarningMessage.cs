
namespace Pendopo.TraningGame.Message
{
    public struct SetWarningMessage : ISetMessage
    {

        public string data { get; set; }
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