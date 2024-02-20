using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.MassCheck
{

    public class GUI_MassCheckController : ObjectController<GUI_MassCheckController,GUI_MassCheckView>
    {
        public override void SetView(GUI_MassCheckView view)
        {
            base.SetView(view);
            SetCallBack();
        }

        public void OnMassCheckMessage(SetMassMessage _message)
        {
            _view.SetMass($"Mass : {_message.massMessage}");
        }
        private void SetCallBack()
        {
            _view.publishMessage += PublishMessage;
        }

        private void PublishMessage()
        {
            CheckCaseText checkCaseText = new CheckCaseText { textToCheck = _view.t_mass.text };
            Publish<CheckCaseText>(checkCaseText);
        }
    }
}