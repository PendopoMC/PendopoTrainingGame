
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
    public struct SetActiveChoiceLogoMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActiveChoiceLogoMessage(bool active)
        {
            this.active = active;
        }
    }
}