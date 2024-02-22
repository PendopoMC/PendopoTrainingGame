using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using System;

namespace Pendopo.TraningGame.Module.GUIDataCheck
{

    public class GUI_DataCheckController<TController, TView> : ObjectController<TController, TView> where TView : GUI_DataCheckView where TController : GUI_DataCheckController<TController,TView>
    {

        public override void SetView(TView view)
        {
            base.SetView(view);
            SetCallBack();
        }

        public virtual void SetMessage<T>(T _data) where T : ISetMessage
        {
            _view.SetData($"EXP {_data.data}");
        }

        protected virtual void SetCallBack()
        {
        }

        protected virtual void PublishMessage()
        {
        }
    }


}