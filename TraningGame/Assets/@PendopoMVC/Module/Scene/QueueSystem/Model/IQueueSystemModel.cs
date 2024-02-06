using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;

namespace Pendopo.TraningGame.Module.QueueSystem
{
    public interface IQueueSystemModel : IBaseModel
    {
        public GameObjectController currentObject { get; }
        public Case currentCase { get; }
        public int stepChecked { get; }
        public Transform anchorPos { get; }
    }
}