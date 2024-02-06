using System.Collections;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
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
            SetupGameplay();
            if (!_model.currentCase.finalAssesment) Debug.Log("You Approve something Wrong");

        }

        public void OnDenied(DeniedMessage _message)
        {
            SetupGameplay();
            if (_model.currentCase.finalAssesment) Debug.Log("You Denied something Right");
        }

        public void SetupGameplay()
        {
            //Update the Model
            _model.currentCase = _model.Dequeue();
            _view.currentCase = _model.currentCase;

            //Request Object pool to spawn Object
            //ObjectData _caseObjectData = _model.currentCase.objectData;
            //Publish<SpawnObjectMessage>(new SpawnObjectMessage { prefabObject = _caseObjectData.prefabObject, damaged = _caseObjectData.damaged, expire = _caseObjectData.expire, ingredients = _caseObjectData.expire, mass = _caseObjectData.mass });

            //Instantiate Queue
            GameObjectModel _objModel = new GameObjectModel(_model.currentCase.objectData);
            GameObjectView _objView = _view.ObjectView(_objModel.prefabObject);
            _objView.transform.position = _model.anchorPos.position;
            GameObjectController _goC = new GameObjectController();
            InjectDependencies(_goC);
            _goC.Init(_objModel, _objView);
            _model.SetCurrentObject(_goC);

            //Publish event
            //Set Expire date to check
            Publish<SetExpireMessage>(new SetExpireMessage(_model.currentCase.caseData.expire));
            //Set Damaged case to check
            Publish<SetPackageMessage>(new SetPackageMessage(_model.currentCase.caseData.damaged));
            //Set ingredient to check
            Publish<SetIngredientMessage>(new SetIngredientMessage(_model.currentCase.caseData.ingredients));
        }
    }
}