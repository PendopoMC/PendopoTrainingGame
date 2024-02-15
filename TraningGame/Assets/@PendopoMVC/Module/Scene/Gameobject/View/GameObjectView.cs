using Agate.MVC.Base;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Module.PointClick;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectView : ObjectView<IGameObjectModel>
    {
        public PointClickView[] pointClickViews;
        public ObjectData data;
        protected override void InitRenderModel(IGameObjectModel model)
        {
           
        }

        protected override void UpdateRenderModel(IGameObjectModel model)
        { 
        }

        public void DestroyObject()
        {
            Destroy(gameObject);
        }

    }
}
