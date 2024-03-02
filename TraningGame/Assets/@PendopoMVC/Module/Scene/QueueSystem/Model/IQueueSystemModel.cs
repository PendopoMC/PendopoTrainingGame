using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public interface IQueueSystemModel : IBaseModel
    {
        public GameObjectController currentObject { get; }
        public ObjectData currentCase { get; }
        public int stepChecked { get; }
        public Transform anchorPos { get; }
        public Queue<ObjectData> CasePool { get; }
        public GameObject currentGameObject { get; }
    }
}