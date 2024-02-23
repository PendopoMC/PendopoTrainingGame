
namespace Pendopo.TraningGame.Message
{
    public struct SetLogoCodeMessage : ISetMessage
    {
        public SetLogoCodeMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetLogoCodeMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetLogoCodeMessage(bool active)
        {
            this.active = active;
        }
    }
}