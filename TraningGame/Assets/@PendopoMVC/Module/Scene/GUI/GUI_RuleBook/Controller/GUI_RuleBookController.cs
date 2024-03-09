using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.GUIRuleBook
{

    public class GUI_RuleBookController : ObjectController<GUI_RuleBookController,GUI_RuleBookView>
    {
        public void MissionCallback(MissionCallbackMessage _mission)
        {
            _view.SetTextMission(_mission.mission);
        }
    }
}