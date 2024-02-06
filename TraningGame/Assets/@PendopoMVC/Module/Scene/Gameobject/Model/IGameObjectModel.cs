using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.Object
{
    public interface IGameObjectModel : IBaseModel
    {

        public string prefabObject { get; }
        public string expire { get; }
        public string ingredients { get; }
        public string mass { get; }
        public bool damaged { get; }
    }
}
