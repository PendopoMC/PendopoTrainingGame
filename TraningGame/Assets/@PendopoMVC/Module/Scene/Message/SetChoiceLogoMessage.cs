
namespace Pendopo.TraningGame.Message
{
    public struct SetChoiceLogoMessage : ISetMessage
    {
        public SetChoiceLogoMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}