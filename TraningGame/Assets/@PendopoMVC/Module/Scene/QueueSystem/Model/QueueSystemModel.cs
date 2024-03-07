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

        public Transform anchorPos { get; private set; }

        public GameObject currentGameObject { get; private set; }

        public List<ObjectData> caseObjectList { get; set; }

        public LevelCase currentCase { get; private set; }

        public void SetCurrentObject(GameObjectController _goC,GameObject _go)
        {
            
            currentObject = _goC;
            currentGameObject = _go;
        }


        public void SetAnchor(Transform _anchor)
        {
            anchorPos = _anchor;
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