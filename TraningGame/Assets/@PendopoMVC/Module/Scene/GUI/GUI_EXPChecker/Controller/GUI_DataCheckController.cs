using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.ExpireCheck
{

    public class GUI_DataCheckController : ObjectController<GUI_DataCheckController, GUI_DataCheckView>
    {
        public override void SetView(GUI_DataCheckView view)
        {
            base.SetView(view);
            SetCallBack();
        }

        public void OnEXPMessage(SetExpireMessage _expMessage)
        {
            _view.SetData($"EXP {_expMessage.expireMessage}");
        }


        private void SetCallBack()
        {
            _view.publishMessage += PublishMessage;
        }

        private void PublishMessage()
        {
            CompareCheck checkCaseText = new CompareCheck { data = _view.t_data.text };
            Publish<CompareCheck>(checkCaseText);
        }
    }

}