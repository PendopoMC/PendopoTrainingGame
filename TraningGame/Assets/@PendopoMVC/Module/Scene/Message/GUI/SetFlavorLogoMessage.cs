
namespace Pendopo.TraningGame.Message
{
    public struct SetFlavorLogoMessage : ISetMessage
    {
        public SetFlavorLogoMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetFlavorLogoMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetFlavorLogoMessage(bool active)
        {
            this.active = active;
        }
    }
}