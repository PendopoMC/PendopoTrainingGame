
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
    
    public struct SetProductionCodeMessage : ISetMessage
    {
        public SetProductionCodeMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetIngredientMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetIngredientMessage(bool active)
        {
            this.active = active;
        }
    }
}