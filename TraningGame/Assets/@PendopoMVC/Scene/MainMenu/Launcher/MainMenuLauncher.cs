using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Boot;
using Pendopo.TraningGame.Module.MainMenuCanvas;

namespace Pendopo.TraningGame.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName { get { return GameScene.MainMenu; } }
        MainMenuCanvasController mainMenuCanvasController;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new MainMenuCanvasController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            mainMenuCanvasController.SetView(_view.mainMenuCanvas);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}