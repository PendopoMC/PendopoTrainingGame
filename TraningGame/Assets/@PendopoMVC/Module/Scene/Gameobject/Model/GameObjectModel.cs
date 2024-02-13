using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectModel : BaseModel, IGameObjectModel
    {
        public GameObjectModel()
        {

        }
        public GameObjectModel(string expire, bool checkValue, string prefabObject, string ingredients, string mass, bool damaged)
        {
            this.expire = expire;
            this.checkValue = checkValue;
            this.prefabObject = prefabObject;
            this.ingredients = ingredients;
            this.mass = mass;
            this.damaged = damaged;
        }
        public GameObjectModel(ObjectData _data)
        {
            expire = _data.expire;
            prefabObject = _data.prefabObject;
            ingredients = _data.ingredients;
            mass = _data.mass;
        }

        public string expire { get; private set; }

        public bool checkValue { get; private set; }

        public string prefabObject { get; private set; }

        public string ingredients { get; private set; }

        public string mass { get; private set; }

        public bool damaged { get; private set; }

        public string color { get; private set; }
        public string productName { get; private set; }

        public string productionCode { get; private set; }

        public string barCode { get; private set; }

        public string QRCode { get; private set; }
    }
}
