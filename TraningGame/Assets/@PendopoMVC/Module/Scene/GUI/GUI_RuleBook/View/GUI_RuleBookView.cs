using UnityEngine;
using Agate.MVC.Base;
using TMPro;
namespace Pendopo.TraningGame.Module.GUIRuleBook
{
    public class GUI_RuleBookView : BaseView
    {
        [SerializeField] private TextMeshProUGUI t_package;

        internal void SetTextMission(string _mission)
        {
            t_package.SetText(_mission);
        }
    }
}
