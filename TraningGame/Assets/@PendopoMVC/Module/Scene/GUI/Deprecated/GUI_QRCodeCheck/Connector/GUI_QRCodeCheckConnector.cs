using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.QRCodeCheck
{
    public class GUI_QRCodeCheckConnector : BaseConnector
    {
        GUI_QRCodeCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.SetMessage);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.SetMessage);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}