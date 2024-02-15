using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.Object
{
    public interface IGameObjectModel : IBaseModel
    {
        public ObjectData data { get; }
    }
}
