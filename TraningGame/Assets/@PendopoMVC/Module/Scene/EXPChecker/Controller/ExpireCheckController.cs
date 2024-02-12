using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.ExpireCheck
{

    public class ExpireCheckController : ObjectController<ExpireCheckController,ExpireCheckView>
    {
        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }

        public override void SetView(ExpireCheckView view)
        {
            base.SetView(view);
        }

        public void OnEXPMessage(SetExpireMessage _expMessage)
        {
            _view.SetExp($"EXP {_expMessage.expireMessage}");
        }
    }

}