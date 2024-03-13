using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.Core.Helper;
using DG.Tweening;

namespace Pendopo.TraningGame.Module.QueueSystem
{

    /// <summary>
    /// TO DO Arief : Load every Count Case and shuffle after last case played
    /// </summary>
    public class QueueSystemController : ObjectController<QueueSystemController, QueueSystemModel, IQueueSystemModel, QueueSystemView>
    {
        GameObjectModel objModel;
        GameObjectController goC;
        RequestObject requestObject;
        RequestReturnObject requestReturn;
        SetMassMessage massMessage;
        StartTimeAttack startTimeAttackMessage;
        public override void SetView(QueueSystemView view)
        {
            base.SetView(view);
            objModel = new GameObjectModel();
            goC = new GameObjectController();
            requestReturn = new RequestReturnObject();
            requestObject = new RequestObject();
            startTimeAttackMessage = new StartTimeAttack();
            massMessage = new SetMassMessage();
            _model.SetAnchor(_view.tr_anchorEnd, _view.tr_anchorSpawn, _view.tr_andhorReject, _view.tr_anchorApprove);
            _view.SetCallback(delegate { Publish<StartPlayMessage>(new StartPlayMessage()); });

            //Change this to use CaseDataCollectionController
            Publish<RequestCaseQueue>(new RequestCaseQueue());
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
            if (_model.isQueueing) return;
            Debug.Log(!_model.currentCaseObject.finalAssesment ? "You Approve something Wrong" : "You Approve right");
            _view.StartCoroutine(MoveToTargetPosiution(_model.tr_anchorApprove.position, delegate { SetupGameplay(); }));
        }

        public void OnDenied(DeniedMessage _message)
        {
            if (_model.isQueueing) return;
            Debug.Log(_model.currentCaseObject.finalAssesment ? "You Denied something Right" : "You Deny right");
            _view.StartCoroutine(MoveToTargetPosiution(_model.tr_andhorReject.position,  delegate { SetupGameplay(); }));
        }

        private void SetupGameplay()
        {
            if (_model.currentGameObject)
            {
                requestReturn.gameobjectView = _model.currentGameObject;
                requestReturn.prefabName = _model.currentCaseObject.PackageName;
                _model.currentObject.SetupReturn();
                Publish<RequestReturnObject>(requestReturn);
            }

            //Update the Model
            _model.currentCaseObject = _model.GetCaseObject();
            _model.caseIndex++;
            if (_model.caseIndex > _model.caseObjectList.Count - 1)
            {
                _model.caseIndex = 0;
                Shuffler.Shuffle<ObjectData>(_model.caseObjectList);
                _view.cases.csv_cases = _model.caseObjectList;
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
            InjectDependencies(goC);
            goC.Init(objModel, _objectViewRequested);
            _model.SetCurrentObject(goC, _objectViewRequested);
            _model.currentGameObject.gameObject.transform.position = _model.tr_anchorSpawn.position;

            ////Set Mass to check
            massMessage.data = _model.currentCaseObject.Berat;
            Publish<SetMassMessage>(massMessage);
            _view.StartCoroutine(MoveToTargetPosiution(_model.tr_anchorEnd.position));
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

        IEnumerator MoveToTargetPosiution(Vector3 _endPos,UnityAction _doAfter=null)
        {
            _model.isQueueing = true;
            _model.currentGameObject.gameObject.transform.DOMove(_endPos, 3f);
            yield return new WaitForSeconds(3f);
            _model.isQueueing = false;
            _doAfter?.Invoke();
        }
    }
}