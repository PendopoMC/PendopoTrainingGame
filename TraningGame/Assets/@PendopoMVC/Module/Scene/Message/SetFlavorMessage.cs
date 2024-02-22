
namespace Pendopo.TraningGame.Message
{
    public struct SetFlavorMessage : ISetMessage
    {
        public SetFlavorMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}