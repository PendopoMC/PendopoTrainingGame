using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class IngredientCheckController : ObjectController<IngredientCheckController,IngredientCheckView>
    {
        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }

        public override void SetView(IngredientCheckView view)
        {
            base.SetView(view);
        }


        public void OnIngredientMessage(SetIngredientMessage _mseesage)
        {
            _view.SetIngredient($"Ingredients : {_mseesage.ingredientMessage}");
        }
    }
}