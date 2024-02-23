
namespace Pendopo.TraningGame.Message
{
    public struct SetBarCodeMessage : ISetMessage
    {
        public SetBarCodeMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}