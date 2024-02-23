namespace Pendopo.TraningGame.Message
{
    public struct SetExpireMessage: ISetMessage
    {
        public SetExpireMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }      
    }

    public struct SetActivetExpireMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetExpireMessage(bool active)
        {
            this.active = active;
        }
    }
}