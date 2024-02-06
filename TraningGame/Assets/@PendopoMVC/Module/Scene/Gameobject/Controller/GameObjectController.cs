using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectController : ObjectController<GameObjectController,GameObjectModel,IGameObjectModel,GameObjectView>
    {
        public override void SetView(GameObjectView view)
        {
            base.SetView(view);

        }
        public void Init(GameObjectModel model, GameObjectView view)
        {
            _model = model;
            SetView(view);
        }
    }
}
