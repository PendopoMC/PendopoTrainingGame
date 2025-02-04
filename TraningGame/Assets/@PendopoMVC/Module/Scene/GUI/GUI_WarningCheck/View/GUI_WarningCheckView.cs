using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;
using TMPro;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.GUIDataCheck;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.WarningCheck
{
    public class GUI_WarningCheckView : GUI_DataCheckView
    {
        public float delayToFade;
        public Image i_graphic;
        public Sprite s_correct, s_wrong;
        public void SetData(SetWarningMessage _data)
        {
            t_data.text = _data.data;
            i_graphic.sprite = _data.isCorrect ? s_correct : s_wrong;
        }

      
    }
}