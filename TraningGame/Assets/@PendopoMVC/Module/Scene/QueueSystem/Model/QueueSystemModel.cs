using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;

namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemModel : BaseModel, IQueueSystemModel
    {
        private Queue<ObjectData> casePool = new Queue<ObjectData>();
        public int stepChecked { get; private set; }

        public GameObjectController currentObject { get; private set; }

        public ObjectData currentCase { get; set; }

        public Transform anchorPos { get; private set; }

        public GameObject currentGameObject { get; private set; }

        public Queue<ObjectData> CasePool { get => casePool; }

        public void SetCurrentObject(GameObjectController _goC,GameObject _go)
        {
            
            currentObject = _goC;
            currentGameObject = _go;
        }


        public void SetAnchor(Transform _anchor)
        {
            anchorPos = _anchor;
        }
        public void Enqueue(ObjectData _item)
        {
            casePool.Enqueue(_item);
            SetDataAsDirty();
        }

        public ObjectData Dequeue()
        {
            return casePool.Dequeue();
        }
    }
}