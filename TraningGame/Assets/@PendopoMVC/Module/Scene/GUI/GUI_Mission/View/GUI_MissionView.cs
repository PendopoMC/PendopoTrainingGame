using UnityEngine;
using Agate.MVC.Base;
using TMPro;
namespace Pendopo.TraningGame.Module.GUIMission
{
    public class GUI_MissionView : BaseView
    {
        [SerializeField] private TextMeshProUGUI t_textMission;

        internal void SetTextMission(string _mission)
        {
            t_textMission.SetText(_mission);
        }
    }
}
