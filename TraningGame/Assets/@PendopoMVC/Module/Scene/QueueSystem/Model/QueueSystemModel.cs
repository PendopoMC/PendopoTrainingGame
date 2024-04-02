using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;

namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemModel : BaseModel, IQueueSystemModel
    {
        public int caseIndex { get; set; }

        public GameObjectController currentObject { get; private set; }

        public ObjectData currentCaseObject { get; set; }


        public GameObjectView currentGameObject { get; private set; }

        public List<ObjectData> caseObjectList { get; set; }

        public LevelCase currentCase { get; private set; }

        public Transform tr_anchorEnd { get; private set; }

        public Transform tr_anchorSpawn { get; private set; }

        public Transform tr_andhorReject { get; private set; }

        public Transform tr_anchorApprove { get; private set; }

        public bool isQueueing { get; set; }

        public Transform tr_anchorPickUp { get; private set; }

        public void SetCurrentObject(GameObjectController _goC, GameObjectView _go)
        {
            
            currentObject = _goC;
            currentGameObject = _go;
        }


        public void SetAnchor(Transform _anchorEnd, Transform _anchorSpawn, Transform _anchorPick, Transform _anchorReject, Transform _anchorApprove)
        {
            tr_anchorEnd = _anchorEnd;
            tr_anchorSpawn = _anchorSpawn;
            tr_andhorReject = _anchorReject;
            tr_anchorApprove = _anchorApprove;
            tr_anchorPickUp = _anchorPick;
        }
        public void SetCaseList(List<ObjectData> _item)
        {
            caseObjectList = _item;
        }
            public void SetCase(LevelCase _item)
        {
            currentCase = _item;
        }
        

        public ObjectData GetCaseObject()
        {
            return caseObjectList[caseIndex];
        }
    }
}