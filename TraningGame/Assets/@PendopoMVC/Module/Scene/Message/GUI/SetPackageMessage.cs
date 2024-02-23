
namespace Pendopo.TraningGame.Message
{
    public struct SetPackageMessage
    {
        public bool isBroken { get; private set; }

        public SetPackageMessage(bool isBroken)
        {
            this.isBroken = isBroken;
        }
    }
    public struct SetActivetPackageMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetPackageMessage(bool active)
        {
            this.active = active;
        }
    }
}