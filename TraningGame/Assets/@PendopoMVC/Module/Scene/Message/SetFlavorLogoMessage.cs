
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
}