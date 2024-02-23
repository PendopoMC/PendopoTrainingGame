
namespace Pendopo.TraningGame.Message
{
    public struct SetSealPackMessage : ISetMessage
    {
        public SetSealPackMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetSealPackMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetSealPackMessage(bool active)
        {
            this.active = active;
        }
    }
}