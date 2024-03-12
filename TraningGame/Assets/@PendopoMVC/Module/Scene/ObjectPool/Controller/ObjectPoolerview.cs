using UnityEngine;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;

namespace Pendopo.TraningGame.Module.ObjectPool
{
    public class ObjectPoolerview : ObjectView<IObjectPoolerModel>
    {
        public GameObjectView[] objectPrefabs;
        public int populateCount;
        protected override void InitRenderModel(IObjectPoolerModel model)
        {

        }

        protected override void UpdateRenderModel(IObjectPoolerModel model)
        {

        }
        public GameObjectView ObjectView(string _prefabName)
        {
            GameObjectView _obj = Instantiate(Resources.Load(_prefabName, typeof(GameObjectView)) as GameObjectView, transform);
            _obj.name = _prefabName;
            return _obj;
        }
    }

}