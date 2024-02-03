using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemController : ObjectController<QueueSystemController,QueueSystemModel,IQueueSystemModel,QueueSystemView>
    {

        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }
        public override void SetView(QueueSystemView view)
        {
            base.SetView(view);
        }

        public void OnApprove(OnAprrove _message)
        {

        }

        public void OnDenied(OnDenied _message)
        {

        }



    }

    public class QueueSystemConnector : BaseConnector
    {
        private QueueSystemController _queueSystem;
        protected override void Connect()
        {
            Subscribe<OnAprrove>(_queueSystem.OnApprove);
            Subscribe<OnDenied>(_queueSystem.OnDenied);
        }

        protected override void Disconnect()
        {
            Unsubscribe<OnAprrove>(_queueSystem.OnApprove);
            Unsubscribe<OnDenied>(_queueSystem.OnDenied);
        }
    }
    public class QueueSystemModel : BaseModel, IQueueSystemModel
    {
        [SerializeField] private GameObject prefabs;
        private Queue<BaseCase> casePool = new Queue<BaseCase>();

        public void Enqueue(BaseCase _item)
        {
            casePool.Enqueue(_item);
        }

        public BaseCase Dequeue()
        {
            return casePool.Dequeue();
        }
    }


    public class QueueSystemView : ObjectView<IQueueSystemModel>
    {
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnObstacle;

        protected override void InitRenderModel(IQueueSystemModel model)
        {
        }

        protected override void UpdateRenderModel(IQueueSystemModel model)
        {
        }
        public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnObstacle)
        {
            _onMovePosition = onMovePosition;
            _onDespawnObstacle = onDespawnObstacle;
        }

    }

    public interface IQueueSystemModel : IBaseModel
    {

    }
}