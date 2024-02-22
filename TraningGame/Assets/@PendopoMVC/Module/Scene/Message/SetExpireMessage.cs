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
}