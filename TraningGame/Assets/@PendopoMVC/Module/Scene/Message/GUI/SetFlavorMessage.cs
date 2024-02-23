
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
    public struct SetActivetFlavorMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetFlavorMessage(bool active)
        {
            this.active = active;
        }
    }
}