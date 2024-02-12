
namespace Pendopo.TraningGame.Message
{
    public struct SetIngredientMessage
    {
        public string ingredientMessage { get; private set; }
        public SetIngredientMessage(string ingredientMessage)
        {
            this.ingredientMessage = ingredientMessage;
        }
    }
}