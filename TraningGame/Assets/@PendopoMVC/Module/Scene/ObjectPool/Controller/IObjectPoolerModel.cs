using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;

namespace Pendopo.TraningGame.Module.ObjectPool
{
    public interface IObjectPoolerModel : IBaseModel
    {
        public Dictionary<string,Stack<GameObjectView>> dictPool { get; }
    }

}