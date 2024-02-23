
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
    public struct SetActiveCustomerCareMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActiveCustomerCareMessage(bool active)
        {
            this.active = active;
        }
    }
}