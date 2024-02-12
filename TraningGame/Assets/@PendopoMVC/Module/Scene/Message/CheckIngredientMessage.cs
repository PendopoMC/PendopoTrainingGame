
namespace Pendopo.TraningGame.Message
{
    public struct CheckIngredientMessage
    {

        private bool active;

        public CheckIngredientMessage(bool active)
        {
            this.active = active;
        }
    }
}