using UnityEngine;
using Agate.MVC.Base;
using TMPro;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckView : BaseView
    {
        [SerializeField] private TextMeshProUGUI t_ingredient;

        public void SetIngredient(string _ingredient)
        {
            t_ingredient.text = _ingredient;
        }
    }
}