using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.FlavorLogoCheck
{
    public class GUI_FlavorLogoCheckConnector : BaseConnector
    {
        GUI_FlavorLogoCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.SetMessage);
            Subscribe<SetActivetFlavorLogoMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.SetMessage);
            Unsubscribe<SetActivetFlavorLogoMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}