using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckConnector : BaseConnector
    {
        GUI_IngredientCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.OnIngredientMessage);
            Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.OnIngredientMessage);
            Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}