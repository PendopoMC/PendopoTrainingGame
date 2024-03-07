using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.GUIMission
{

    public class GUI_MissionController : ObjectController<GUI_MissionController,GUI_MissionView>
    {
        public void MissionCallback(MissionCallbackMessage _mission)
        {
            _view.SetTextMission(_mission.mission);
        }
    }
}