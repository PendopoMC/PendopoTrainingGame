using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class IngredientCheckConnector : BaseConnector
    {
        IngredientCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.OnIngredientMessage);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.OnIngredientMessage);
        }
    }
}