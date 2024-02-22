
namespace Pendopo.TraningGame.Message
{
    public struct SetIngredientEngMessage : ISetMessage
    {
        public SetIngredientEngMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }  
}