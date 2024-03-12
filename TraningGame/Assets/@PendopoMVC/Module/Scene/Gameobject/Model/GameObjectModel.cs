using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Module.PointClick;
using System.Collections;
using System.Collections.Generic;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectModel : BaseModel, IGameObjectModel
    {
        public GameObjectModel()
        {

        }
        public void Setdata(ObjectData _data)
        {
            data = _data;
        }


        public List<PointClickController> pointClickControllers = new List<PointClickController>();

        public ObjectData data { get; private set; }
    }
}
