using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Module.Object;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Pendopo.TraningGame.Module.ObjectPool
{
    public class ObjectPoolController:ObjectController<ObjectPoolController, ObjectPoolModel, IObjectInspectModel , ObjectPoolView>
    {
        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }

        public void OnStartPlay(SpawnObjectMessage _message)
        {
            
        }
    }

    public class ObjectPoolModel : BaseModel, IObjectInspectModel 
    {
        public int poolSize { get; private set; } = 4;
        public GameObjectView currentGameObject { get; private set; }       

        public void SetCurrentObject(GameObjectView _goView)
        {
            currentGameObject = _goView;
        }
    }

    public interface IObjectInspectModel :IBaseModel
    {
        public int poolSize { get; }
        public GameObjectView currentGameObject { get; }
    }

    public class ObjectPoolView : ObjectView<IObjectInspectModel >
    {
        public PrefabReference[] prefabReferences;
        protected override void InitRenderModel(IObjectInspectModel  model)
        {
            return;
        }

        protected override void UpdateRenderModel(IObjectInspectModel  model)
        {
            return;
        }
    }

    public struct PrefabReference
    {
        public string prefabName;
        public GameObjectView prefab;
    }
}