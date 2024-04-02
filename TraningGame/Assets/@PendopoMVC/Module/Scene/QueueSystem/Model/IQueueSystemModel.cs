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
        public Transform tr_anchorEnd { get; }
        public Transform tr_anchorSpawn { get; }
        public Transform  tr_andhorReject{ get; }
        public Transform  tr_anchorApprove { get; }
        public Transform  tr_anchorPickUp { get; }
        public List<ObjectData> caseObjectList { get; }
        public GameObjectView currentGameObject { get; }
        public LevelCase currentCase { get; }

        public bool isQueueing { get; }
    }
}