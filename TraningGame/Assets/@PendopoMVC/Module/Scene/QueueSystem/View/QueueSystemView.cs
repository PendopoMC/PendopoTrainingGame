using UnityEngine.Events;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemView : ObjectView<IQueueSystemModel>
    {
        public BaseCase[] baseCases;
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnObject;

        protected override void InitRenderModel(IQueueSystemModel model)
        {
        }

        protected override void UpdateRenderModel(IQueueSystemModel model)
        {
        }
        public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnObject)
        {
            _onMovePosition = onMovePosition;
            _onDespawnObject = onDespawnObject;
        }

    }
}