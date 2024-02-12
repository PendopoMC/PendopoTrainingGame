
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
}