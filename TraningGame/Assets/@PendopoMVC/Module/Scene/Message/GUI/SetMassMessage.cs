
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
    
    
    public struct SetDateMessage : ISetMessage
    {
        public SetDateMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetMassMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetMassMessage(bool active)
        {
            this.active = active;
        }
    }
}