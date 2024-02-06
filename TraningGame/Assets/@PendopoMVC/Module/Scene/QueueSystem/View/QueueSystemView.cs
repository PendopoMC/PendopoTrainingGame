using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using Pendopo.TraningGame.Module.Object;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemView : ObjectView<IQueueSystemModel>
    {
        public Case currentCase;
        public Case[] baseCases;
        public List< PrefabReference> prefabReferences = new List<PrefabReference>();

        protected override void InitRenderModel(IQueueSystemModel model)
        {
        }

        protected override void UpdateRenderModel(IQueueSystemModel model)
        {
        }
        public GameObjectView ObjectView(string _prefabName)
        {
            GameObjectView _obj = Instantiate(prefabReferences.Find(x => x.prefabName == _prefabName).prefab,transform);
            _obj.name = _prefabName;
            return _obj;
        }
    }


    public struct PrefabReference
    {
        public string prefabName;
        public GameObjectView prefab;
    }
}