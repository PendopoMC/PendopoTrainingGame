
namespace Pendopo.TraningGame.Message
{
    public struct SetIngredientMessage : ISetMessage
    {
        public SetIngredientMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}