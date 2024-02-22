
namespace Pendopo.TraningGame.Message
{
    public struct SetMassMessage : ISetMessage
    {
        public SetMassMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    
    public struct SetStrawMessage : ISetMessage
    {
        public SetStrawMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }   
    public struct SetTasteMessage : ISetMessage
    {
        public SetTasteMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}