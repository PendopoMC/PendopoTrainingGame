using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.IngredientEngCheck
{
    public class GUI_IngredientEngCheckConnector : BaseConnector
    {
        GUI_IngredientEngCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetIngredientEngMessage>(_control.SetMessage);
            Subscribe<SetActivetIngredientEngMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetIngredientEngMessage>(_control.SetMessage);
            Unsubscribe<SetActivetIngredientEngMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}