using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.QueueSystem
{

    /// <summary>
    /// TO DO Arief  Change this to use CaseDataCollectionController
    /// </summary>
    public class QueueSystemController : ObjectController<QueueSystemController, QueueSystemModel, IQueueSystemModel, QueueSystemView>
    {
        public override IEnumerator Finalize()
        {
            return base.Finalize();
        }
        public override void SetView(QueueSystemView view)
        {
            base.SetView(view);
            _model.SetAnchor(_view.anchor);
            _view.SetCallback(delegate { Publish<StartPlayMessage>(new StartPlayMessage()); });

            //Change this to use CaseDataCollectionController
            Publish<RequestCaseQueue>(new RequestCaseQueue ());
        }

        public void StartGame(RequestCaseQueueCallback _message)
        {
            InitQueue(_message.caseCollection);
        }

        public void Gameover(GameOverMessage _emssage)
        {
        }

        private void InitQueue(List<ObjectData> _list)
        {
            _view.cases.csv_cases = _list;
          
            for (int i = 0; i < _list.Count; i++)
            {
                _model.Enqueue(_list[i]);
            }
            SetupGameplay();
        }

        public void OnApprove(ApproveMessage _message)
        {
            Debug.Log(!_model.currentCase.finalAssesment ? "You Approve something Wrong" : "You Approve right");
            SetupGameplay();

        }

        public void OnDenied(DeniedMessage _message)
        {
            Debug.Log(_model.currentCase.finalAssesment ? "You Denied something Right" : "You Deny right");
            SetupGameplay();
        }

        private void SetupGameplay()
        {
            if (_model.currentGameObject) _view.RemovingPreviousObject(_model.currentGameObject);
            if (_model.CasePool.Count < 1) return;
            //Update the Model
            _model.currentCase = _model.Dequeue();
            _view.currentCase = _model.currentCase;

            //Request Object pool to spawn Object But for now just spawn it
            //Instantiate Queue
            GameObjectModel _objModel = new GameObjectModel(_model.currentCase);
            GameObjectView _objView = _view.ObjectView(_objModel.data.PackageName);
            GameObjectController _goC = new GameObjectController();
            
            _objView.transform.position = _model.anchorPos.position;
            InjectDependencies(_goC);
            _goC.Init(_objModel, _objView);
            _model.SetCurrentObject(_goC, _objView.gameObject);

            ////Publish event
            ////Set Expire date to check
            //Publish<SetExpireMessage>(new SetExpireMessage(_model.currentCase.caseData.EXP));
            ////Set ingredient to check
            //Publish<SetIngredientMessage>(new SetIngredientMessage(_model.currentCase.caseData.komposisiInd));
            ////Set Mass to check
            //Publish<SetMassMessage>(new SetMassMessage(_model.currentCase.caseData.berat));

            Publish<StartTimeAttack>(new StartTimeAttack { maxTime = 300 });
        }

        public void RotateObject(RotateMessage _message)
        {
            if (Model.currentObject == null) return;
            Model.currentObject.RotateObject(_message);
        }
    }
}