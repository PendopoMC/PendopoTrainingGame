
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
}