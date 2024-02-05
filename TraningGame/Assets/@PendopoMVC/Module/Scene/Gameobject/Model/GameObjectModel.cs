using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectModel : BaseModel, IGameObjectModel
    {
        public string expire { get; private set; }

        public bool checkValue { get; private set; }
    }
}
