using System.Collections;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemController : ObjectController<QueueSystemController, QueueSystemModel, IQueueSystemModel, QueueSystemView>
    {

        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }
        public override void SetView(QueueSystemView view)
        {
            base.SetView(view);
            InitQueue();
        }

        public void StartGame(StartPlayMessage _emssage)
        {
            _model.currentCase = _model.Dequeue();
            SetupGameplay();
        } 
        
        public void Gameover(GameOverMessage _emssage)
        {

        }

        private void InitQueue()
        {
            for (int i = 0; i < _view.baseCases.Length; i++)
            {
                _model.Enqueue(_view.baseCases[i]);
            }
        }

        public void OnApprove(ApproveMessage _message)
        {
            _model.currentCase = _model.Dequeue();
            SetupGameplay();
            if (!_model.currentCase.finalAssesment) Debug.Log("You Approve something Wrong");

        }

        public void OnDenied(DeniedMessage _message)
        {
            _model.currentCase = _model.Dequeue();
            SetupGameplay();
            if (_model.currentCase.finalAssesment) Debug.Log("You Denied something Right");
        }

        public void SetupGameplay()
        {
            //Update the view
            //Update the controller
            //Publish event
        }
    }
}