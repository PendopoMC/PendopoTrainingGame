
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
}