
namespace Pendopo.TraningGame.Message
{
    public struct SetQRCodeMessage : ISetMessage
    {
        public SetQRCodeMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    } 
}