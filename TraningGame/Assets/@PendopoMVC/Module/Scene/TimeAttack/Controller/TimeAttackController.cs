using System.Collections;
using System.Collections.Generic;
using Pendopo.TraningGame.Message;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
namespace Pendopo.TraningGame.Module.TimeAttack
{
    public class TimeAttackController :ObjectController<TimeAttackController,TimeAttackModel,ITimeAttackModel,TimeAttackView>
    {
        FinishGame finishGame;
        public override void SetView(TimeAttackView view)
        {
            base.SetView(view);
            finishGame = new FinishGame();
            _view.SetCallback(UpdateTimeAttack);
        }

        public void StartTimeAttack(StartTimeAttack _meessage)
        {
            _model.SetTime(_meessage.maxTime);
        }   
         
        
        public void StopOrResumeTimeAttack(StopOrResumeTimeAttack _meessage)
        {
            _model.SetRunning(_meessage.isStopResumeTimeAttack);
        }

        private void UpdateTimeAttack()
        {
            if (!_model.isRunning) return;
            if (_model.IncreaseTime())
            {
                _view.UpdateText();
                return;
            }

            Publish<FinishGame>(finishGame);
        }

    }
}