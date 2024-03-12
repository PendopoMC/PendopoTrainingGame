
namespace Pendopo.TraningGame.Message
{
    public struct SetMassMessage : ISetMessage
    {
        public string data { get; set; }
    } 
    
    
    public struct SetDateMessage : ISetMessage
    {
        public string data { get; set; }
    }
    public struct SetActivetMassMessage : ISetActiveMessage
    {
        public bool active { get; set; }

    }
}