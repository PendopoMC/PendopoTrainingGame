
namespace Pendopo.TraningGame.Message
{
    public struct SetStrawMessage : ISetMessage
    {
        public SetStrawMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetStrawMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetStrawMessage(bool active)
        {
            this.active = active;
        }
    }
}