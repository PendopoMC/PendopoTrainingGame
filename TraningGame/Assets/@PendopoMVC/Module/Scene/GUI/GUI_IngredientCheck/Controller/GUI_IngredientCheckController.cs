using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckController : ObjectController<GUI_IngredientCheckController,GUI_IngredientCheckView>
    {

        public void OnIngredientMessage(SetIngredientMessage _mseesage)
        {
            _view.SetActive(false);
            _view.SetIngredient($"Ingredients : {_mseesage.ingredientMessage}");
        }
        public void OnOpenGUI(PointClick_IngredientMessage _xp)
        {
            UnityEngine.Debug.Log("Active");
            _view.SetActive();
        }
    }
}