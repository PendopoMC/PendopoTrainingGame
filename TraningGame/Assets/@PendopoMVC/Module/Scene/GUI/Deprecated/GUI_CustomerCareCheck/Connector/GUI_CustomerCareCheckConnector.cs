using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.CustomerCareCheck
{
    public class GUI_CustomerCareCheckConnector : BaseConnector
    {
        GUI_CustomerCareCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientMessage>(_control.SetMessage);
            Subscribe<SetActiveCustomerCareMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientMessage>(_control.SetMessage);
            Unsubscribe<SetActiveCustomerCareMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}