using System.Collections;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Module.Object;

namespace Pendopo.TraningGame.Module.ObjectPool
{
    public class ObjectPoolerController : ObjectController<ObjectPoolerController,ObjectPoolerModel,IObjectPoolerModel,ObjectPoolerview>
    {
        RequestObjectCallback _requestCallback;
        public override void SetView(ObjectPoolerview view)
        {
            base.SetView(view);
            PopulatePool();
            _requestCallback = new RequestObjectCallback();
        }
        public void GetObject(RequestObject _prefabName)
        {
            GameObjectView _pooledView= _model.GetObject(_prefabName.prefabName);
            _requestCallback.gameobjectView = _pooledView;
            Publish<RequestObjectCallback>(_requestCallback);

        }

        public void ReturnObject(RequestReturnObject _request)
        {
            _model.dictPool[_request.prefabName].Push(_request.gameobjectView);
        }


        private void PopulatePool()
        {
            Debug.Log("Request Populate Pool");
            for (int i = 0; i < _view.objectPrefabs.Length; i++)
            {
                _model.dictPool.Add(_view.objectPrefabs[i].name, new System.Collections.Generic.Stack<GameObjectView>());
                for (int j = 0; j < _view.populateCount; j++)
                {
                    GameObjectView _objView = _view.ObjectView(_view.objectPrefabs[i].name);
                    GameObjectModel _goC = new GameObjectModel();
                    _objView.SetModel(_goC);
                    _objView.transform.position = Vector3.zero;
                    _objView.gameObject.SetActive(false);
                    _model.dictPool[_view.objectPrefabs[i].name].Push(_objView);
                }
            }
        }
    }

}