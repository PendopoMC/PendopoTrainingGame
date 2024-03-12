using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.Core.Helper;
namespace Pendopo.TraningGame.Module.QueueSystem
{

    /// <summary>
    /// TO DO Arief : Load every Count Case and shuffle after last case played
    /// </summary>
    public class QueueSystemController : ObjectController<QueueSystemController, QueueSystemModel, IQueueSystemModel, QueueSystemView>
    {
        GameObjectModel objModel;
        GameObjectView objView;
        GameObjectController goC;
        RequestObject requestObject;
        SetMassMessage massMessage;
        StartTimeAttack startTimeAttackMessage;
        public override void SetView(QueueSystemView view)
        {
            base.SetView(view);
            objModel = new GameObjectModel();
            goC = new GameObjectController();
            requestObject = new RequestObject();
            startTimeAttackMessage = new StartTimeAttack();
            massMessage = new SetMassMessage();
            _model.SetAnchor(_view.tr_anchorEnd);
            _view.SetCallback(delegate { Publish<StartPlayMessage>(new StartPlayMessage()); });

        }

        public void StartGame(RequestCaseQueueCallback _message)
        {
            Debug.Log("Start Game Queue up");
            SetCase(_message);
            InitQueue(_message.caseCollection);
            startTimeAttackMessage.maxTime = 300;
            Publish<StartTimeAttack>(startTimeAttackMessage);
        }

        private void SetCase(RequestCaseQueueCallback _message)
        {
            _model.SetCase(_message.caseLevel);
            //publish to inform the mission GUI
            Publish<SetProductionCodeMessage>(new SetProductionCodeMessage ( _message.caseLevel.SubClass.KodeProduksi[0]));
            Publish<MissionCallbackMessage>(new MissionCallbackMessage { mission = _message.caseLevel.Rule });
        }

        public void Gameover(GameOverMessage _emssage)
        {
        }
        
        public void RequestObjectViewCallback(RequestObjectCallback _emssage)
        {
            ModifyObject(_emssage.gameobjectView);
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
            _model.caseIndex++;
            if (_model.caseIndex > _model.caseObjectList.Count - 1)
            {

                _model.caseIndex = 0;
                Shuffler.Shuffle<ObjectData>(_model.caseObjectList);
                _view.cases.csv_cases = _model.caseObjectList;
                Debug.Log("Shuffle");
            }
            _view.currentCase = _model.currentCaseObject;

            requestObject.prefabName = _model.currentCaseObject.PackageName;
            Publish<RequestObject>(requestObject);
        }

        private void ModifyObject(GameObjectView _objectViewRequested)
        {
            //Request Object pool to spawn Object But for now just spawn it
            //Instantiate Queue
            objModel.Setdata(Model.currentCaseObject);
            objView = _objectViewRequested;

            objView.transform.position = _model.anchorPos.position;
            InjectDependencies(goC);
            goC.Init(objModel, objView);
            _model.SetCurrentObject(goC, objView.gameObject);

            ////Set Mass to check
            massMessage.data = _model.currentCaseObject.Berat;
            Publish<SetMassMessage>(massMessage);
        }

        public void RotateObject(RotateMessage _message)
        {
            if (Model.currentObject == null) return;
            Model.currentObject.RotateObject(_message);
        }
        public void ResetRotation(ResetRotateMessage _mesage)
        {
            if (Model.currentObject == null) return;
            Model.currentObject.ResetRotation(_mesage);
        }

    }
}