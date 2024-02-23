using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckConnector : BaseConnector
    {
        GUI_IngredientCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.SetMessage);
            Subscribe<SetActivetIngredientMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.SetMessage);
            Unsubscribe<SetActivetIngredientMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}