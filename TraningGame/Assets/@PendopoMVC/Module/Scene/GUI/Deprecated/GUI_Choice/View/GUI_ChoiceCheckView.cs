using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Agate.MVC.Base;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;

namespace Pendopo.TraningGame.Module.ChoiceCheck
{
    public class GUI_ChoiceCheckView : GUI_DataCheckView
    {
        public TextMeshProUGUI t_mass;
        public override void SetData(string _xp)
        {
            t_mass.text = _xp;
        }
    }
}