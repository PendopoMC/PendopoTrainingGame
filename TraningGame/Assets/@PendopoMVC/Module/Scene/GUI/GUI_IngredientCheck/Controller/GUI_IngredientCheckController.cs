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

        public override void SetView(GUI_IngredientCheckView view)
        {
            base.SetView(view);
            SetCallBack();
        }

        public void OnIngredientMessage(SetIngredientMessage _mseesage)
        {
            _view.SetIngredient($"Ingredients : {_mseesage.ingredientMessage}");
        }
        private void SetCallBack()
        {
            _view.publishMessage += PublishMessage;
        }

        private void PublishMessage()
        {
            CheckCaseText checkCaseText = new CheckCaseText { textToCheck = _view.t_ingredient.text };
            Publish<CheckCaseText>(checkCaseText);
        }
    }
}