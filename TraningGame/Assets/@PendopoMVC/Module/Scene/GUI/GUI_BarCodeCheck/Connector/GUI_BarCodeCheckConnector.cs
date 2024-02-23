using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.BarCodeCheck
{
    public class GUI_BarCodeCheckConnector : BaseConnector
    {
        GUI_BarCodeCheckController _control;
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