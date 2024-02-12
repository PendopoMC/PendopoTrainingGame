
namespace Pendopo.TraningGame.Message
{
    public struct CheckMassMessage
    {
        private bool active;

        public CheckMassMessage(bool active)
        {
            this.active = active;
        }
    }
}