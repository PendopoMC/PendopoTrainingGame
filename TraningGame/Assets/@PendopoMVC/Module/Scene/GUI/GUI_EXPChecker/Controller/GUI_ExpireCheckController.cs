using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.ExpireCheck
{

    public class GUI_ExpireCheckController : ObjectController<GUI_ExpireCheckController, GUI_ExpireCheckView>
    {
        public void OnEXPMessage(SetExpireMessage _expMessage)
        {
            _view.SetActive(false);
            _view.SetExp($"EXP {_expMessage.expireMessage}");
        }

        public void OnOpenEXP(PointClick_EXPMessage _xp)
        {
            _view.SetActive();
        }
    }

}