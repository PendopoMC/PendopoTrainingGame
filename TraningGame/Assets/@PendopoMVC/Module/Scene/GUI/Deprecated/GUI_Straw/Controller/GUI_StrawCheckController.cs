using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Module.GUIDataCheck;

namespace Pendopo.TraningGame.Module.StrawCheck
{

    public class GUI_StrawCheckController : GUI_DataCheckController<GUI_StrawCheckController,GUI_StrawCheckView>
    {
        public override void SetView(GUI_StrawCheckView view)
        {
            base.SetView(view);
            SetCallBack();
        }
        public override void SetMessage<T>(T _expMessage)
        {
            _view.SetData($"Mass : {_expMessage.data}");
        }
       
        protected override void PublishMessage()
        {
            CompareCheck checkCaseText = new CompareCheck { data = _view.t_mass.text };
            Publish<CompareCheck>(checkCaseText);
        }
    }
}