
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
}