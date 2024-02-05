using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.Object
{
    public interface IGameObjectModel : IBaseModel
    {

        public string expire { get; }
        public bool checkValue { get; }
    }
}
