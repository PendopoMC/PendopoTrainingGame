using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.ExpireCheck
{

    public class GUI_ExpireCheckController : ObjectController<GUI_ExpireCheckController, GUI_ExpireCheckView>
    {
        public override void SetView(GUI_ExpireCheckView view)
        {
            base.SetView(view);
            SetCallBack();
        }

        public void OnEXPMessage(SetExpireMessage _expMessage)
        {
            _view.SetExp($"EXP {_expMessage.expireMessage}");
        }


        private void SetCallBack()
        {
            _view.publishMessage += PublishMessage;
        }

        private void PublishMessage()
        {
            CheckCaseText checkCaseText = new CheckCaseText { textToCheck = _view.t_exp.text };
            Publish<CheckCaseText>(checkCaseText);
        }
    }

}