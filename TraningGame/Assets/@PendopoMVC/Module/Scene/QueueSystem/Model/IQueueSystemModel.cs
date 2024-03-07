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
        public ObjectData currentCaseObject { get; }
        public int caseIndex { get; }
        public Transform anchorPos { get; }
        public List<ObjectData> caseObjectList { get; }
        public GameObject currentGameObject { get; }
        public LevelCase currentCase { get; }
    }
}