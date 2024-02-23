using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.NutritionFactCheck
{
    public class GUI_NutritionFactCheckConnector : BaseConnector
    {
        GUI_NutritionFactCheckController _control;
        protected override void Connect()
        {
            Subscribe<SetNutritionFactMessage>(_control.SetMessage);
            Subscribe<SetActivetNutritionFactMessage>(_control.SetActive);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetNutritionFactMessage>(_control.SetMessage);
            Unsubscribe<SetActivetNutritionFactMessage>(_control.SetActive);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}