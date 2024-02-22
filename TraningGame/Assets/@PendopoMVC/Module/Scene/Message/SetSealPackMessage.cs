
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
}