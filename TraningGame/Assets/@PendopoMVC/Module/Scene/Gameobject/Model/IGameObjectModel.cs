using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;
namespace Pendopo.TraningGame.Module.Object
{
    public interface IGameObjectModel : IBaseModel
    {
        public ObjectData data { get; }
        public Rigidbody rb { get; }
    }
}
