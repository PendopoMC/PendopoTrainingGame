
namespace Pendopo.TraningGame.Message
{
    public struct SetNutritionFactMessage : ISetMessage
    {
        public SetNutritionFactMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
    public struct SetActivetNutritionFactMessage : ISetActiveMessage
    {
        public bool active { get; private set; }

        public SetActivetNutritionFactMessage(bool active)
        {
            this.active = active;
        }
    }
}