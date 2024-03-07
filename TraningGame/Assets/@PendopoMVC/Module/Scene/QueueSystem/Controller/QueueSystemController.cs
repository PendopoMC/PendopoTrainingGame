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
            SetCase(_message);
            InitQueue(_message.caseCollection);
        }

        private void SetCase(RequestCaseQueueCallback _message)
        {
            _model.SetCase(_message.caseLevel);
            //publish to inform the mission GUI
        }

        public void Gameover(GameOverMessage _emssage)
        {
        }

        private void InitQueue(List<ObjectData> _list)
        {
            _view.cases.csv_cases = _list;
            _model.SetCaseList(_list);
            SetupGameplay();
        }

        public void OnApprove(ApproveMessage _message)
        {
            Debug.Log(!_model.currentCaseObject.finalAssesment ? "You Approve something Wrong" : "You Approve right");
            SetupGameplay();

        }

        public void OnDenied(DeniedMessage _message)
        {
            Debug.Log(_model.currentCaseObject.finalAssesment ? "You Denied something Right" : "You Deny right");
            SetupGameplay();
        }

        private void SetupGameplay()
        {
            if (_model.currentGameObject) _view.RemovingPreviousObject(_model.currentGameObject);

            //Update the Model
            _model.currentCaseObject = _model.GetCaseObject();
            _model.caseIndex = _model.caseIndex >= _model.caseObjectList.Count ? 0 : _model.caseIndex++;
            _view.currentCase = _model.currentCaseObject;

            //Request Object pool to spawn Object But for now just spawn it
            //Instantiate Queue
            GameObjectModel _objModel = new GameObjectModel(_model.currentCaseObject);
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