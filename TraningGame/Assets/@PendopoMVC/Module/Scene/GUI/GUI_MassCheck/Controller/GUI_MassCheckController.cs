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
        public void OnMassCheckMessage(SetMassMessage _message)
        {
            _view.SetMass($"Mass : {_message.massMessage}");
        }
        public void OnOpenGUI(PointClick_MassMessage _xp)
        {
            _view.SetActive();
        }
    }
}