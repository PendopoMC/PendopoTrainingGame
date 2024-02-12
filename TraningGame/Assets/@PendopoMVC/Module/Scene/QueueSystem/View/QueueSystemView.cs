using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using Pendopo.TraningGame.Module.Object;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemView : ObjectView<IQueueSystemModel>
    {
        public Transform anchor;
        public SO_CaseColleciton cases;
        public Case currentCase;
        private UnityAction onTry;
        protected override void InitRenderModel(IQueueSystemModel model)
        {
        }

        protected override void UpdateRenderModel(IQueueSystemModel model)
        {
        }
        public GameObjectView ObjectView(string _prefabName)
        {
            GameObjectView _obj = Instantiate(Resources.Load(_prefabName,typeof(GameObjectView)) as GameObjectView, transform);
            _obj.name = _prefabName;
            return _obj;
        }

        public void SetCallback(UnityAction _try)
        {
            onTry = _try;
        }

        public void RemovingPreviousObject(GameObject _go)
        {
            Destroy(_go);
        }
    }


}