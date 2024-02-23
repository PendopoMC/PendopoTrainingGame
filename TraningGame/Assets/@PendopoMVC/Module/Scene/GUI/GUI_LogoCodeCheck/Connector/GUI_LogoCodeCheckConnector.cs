using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.LogoCodeCheck
{
    public class GUI_LogoCodeCheckConnector : BaseConnector
    {
        GUI_LogoCodeCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetLogoCodeMessage>(_control.SetMessage);
            Subscribe<SetActivetLogoCodeMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetLogoCodeMessage>(_control.SetMessage);
            Unsubscribe<SetActivetLogoCodeMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}