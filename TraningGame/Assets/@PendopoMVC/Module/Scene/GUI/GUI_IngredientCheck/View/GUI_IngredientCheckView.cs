using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;
using TMPro;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;
namespace Pendopo.TraningGame.Module.IngredientCheck
{
    public class GUI_IngredientCheckView : GUI_DataCheckView
    {
        public override void SetData(string _xp)
        {
            t_data.text = _xp;
        }      
    }
}