
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
    public struct SetActivetIngredientEngMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetIngredientEngMessage(bool active)
        {
            this.active = active;
        }
    }
}