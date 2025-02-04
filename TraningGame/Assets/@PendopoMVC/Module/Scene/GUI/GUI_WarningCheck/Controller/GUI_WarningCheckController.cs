using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Module.GUIDataCheck;
using DG.Tweening;

namespace Pendopo.TraningGame.Module.WarningCheck
{
    public class GUI_WarningCheckController : GUI_DataCheckController<GUI_WarningCheckController,GUI_WarningCheckView>
    {
        WaitForSeconds delayWait;
        public override void SetView(GUI_WarningCheckView view)
        {
            base.SetView(view);
            SetCallBack();
            _view.SetActive(false);
            delayWait = new WaitForSeconds(view.delayToFade);
        }

        public override void SetMessage<T>(T _expMessage)
        {
            if (_expMessage is SetWarningMessage warningMessage)
            {
                _view.SetData(warningMessage);
                _view.StartCoroutine(Delay());
            }
            else
            {
                Debug.LogWarning($"Received unknown message type: {typeof(T)}");
            }
        }
        
        IEnumerator Delay()
        {
            _view.SetActive(true);
            _view.i_graphic.CrossFadeAlpha(1, 0, false);
            yield return delayWait;
            _view.i_graphic.CrossFadeAlpha(0, _view.delayToFade,false);
            yield return delayWait;
            _view.SetActive(false);
        }

        protected override void PublishMessage()
        {
            CompareCheck checkCaseText = new CompareCheck { data = _view.t_data.text };
            Publish<CompareCheck>(checkCaseText);
        }

        public string Data()
        {
            return "Hey";
        }
    }
}