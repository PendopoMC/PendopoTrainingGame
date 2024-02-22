using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Agate.MVC.Base;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;

namespace Pendopo.TraningGame.Module.MassCheck
{
    public class GUI_MassCheckView : GUI_DataCheckView
    {
        public override void SetData(string _xp)
        {
            t_data.text = _xp;
        }
    }
}