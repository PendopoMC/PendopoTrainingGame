using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;
using TMPro;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;
namespace Pendopo.TraningGame.Module.QRCodeCheck
{
    public class GUI_QRCodeCheckView : GUI_DataCheckView
    {

        public override void SetData(string _xp)
        {
            t_data.text = _xp;
        }

      
    }
}