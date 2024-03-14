using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;
using TMPro;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;
namespace Pendopo.TraningGame.Module.WarningCheck
{
    public class GUI_WarningCheckView : GUI_DataCheckView
    {
        public float delayToFade;
        public Image i_graphic;
        public override void SetData(string _xp)
        {
            t_data.text = _xp;
        }

      
    }
}