using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using TMPro;
namespace Pendopo.TraningGame.Module.TimeAttack
{
    public class TimeAttackView : ObjectView<ITimeAttackModel>
    {
        [SerializeField] private TextMeshProUGUI t_timer;
        private UnityAction actionUpdateTime;
        protected override void InitRenderModel(ITimeAttackModel model)
        {
            t_timer.SetText(model.timeString);
        }

        protected override void UpdateRenderModel(ITimeAttackModel model)
        {
            t_timer.SetText(model.timeString);
        }
        
        public void SetCallback(UnityAction _updateTime)
        {
            actionUpdateTime = _updateTime;
        }
        public void UpdateText()
        {
            t_timer.SetText(_model.timeString);
        }

        private void Update()
        {
            actionUpdateTime?.Invoke();
        }
    }


}