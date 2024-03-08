using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Module.GUIDataCheck;
namespace Pendopo.TraningGame.Module.WarningCheck
{
    public class GUI_WarningCheckController : GUI_DataCheckController<GUI_WarningCheckController,GUI_WarningCheckView>
    {
        public override void SetView(GUI_WarningCheckView view)
        {
            base.SetView(view);
            SetCallBack();
            _view.SetActive(false);
        }

        public override void SetMessage<T>(T _expMessage)
        {
            _view.SetData($"Ingredients : {_expMessage.data}");
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