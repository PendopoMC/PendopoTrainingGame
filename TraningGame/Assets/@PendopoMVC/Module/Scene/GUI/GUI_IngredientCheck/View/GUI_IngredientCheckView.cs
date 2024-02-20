using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;
using TMPro;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckView : GUI_BaseView
    {
        public TextMeshProUGUI t_ingredient;


        public void SetIngredient(string _ingredient)
        {
            t_ingredient.text = _ingredient;
        }

      
    }
}