using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Boot;
namespace Pendopo.TraningGame.Module.MainMenuCanvas
{
    public class MainMenuCanvasController : ObjectController<MainMenuCanvasController,MainMenuCanvasView>
    {
        public override void SetView(MainMenuCanvasView view)
        {
            base.SetView(view);
            view.SetCallBack(ToGameplay);
        }

        private void ToGameplay()
        {
            SceneLoader.Instance.LoadScene(_view.sceneToLoad);
        }
    }

}
