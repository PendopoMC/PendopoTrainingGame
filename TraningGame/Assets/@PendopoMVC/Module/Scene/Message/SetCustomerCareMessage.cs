
namespace Pendopo.TraningGame.Message
{
    public struct SetCustomerCareMessage : ISetMessage
    {
        public SetCustomerCareMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }    
}