using System.Collections.Generic;
using System.Diagnostics;
using Agate.MVC.Base;
using Pendopo.TraningGame.Module.Object;
using UnityEngine;
namespace Pendopo.TraningGame.Module.ObjectPool
{
    public class ObjectPoolerModel : BaseModel, IObjectPoolerModel
    {
        private Dictionary<string, Stack<GameObjectView>> _dictionaryPool = new Dictionary<string, Stack<GameObjectView>>();
        public Dictionary<string, Stack<GameObjectView>> dictPool 
        {
            get
            {
                return _dictionaryPool;
            }
            private set
            {
                _dictionaryPool = value;
            }
        }

        public void InitialDictionary()
        {
            dictPool = new Dictionary<string, Stack<GameObjectView>>();
        }

        public GameObjectView GetObject(string _prefabName)
        {
            GameObjectView _objPooled = null;
            if (dictPool.ContainsKey(_prefabName))
            {
                if (dictPool[_prefabName].TryPop(out _objPooled))
                {
                    _objPooled.gameObject.SetActive(true);
                    return _objPooled;
                }
            }
            UnityEngine.Debug.LogError($"Return Null, No Prefab: {_prefabName}");
            return _objPooled;
        }


    }

}