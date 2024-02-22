using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Boot;
using Pendopo.TraningGame.Module.GUIDataCheck;
using Pendopo.TraningGame.Module.IngredientCheck;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;
using Pendopo.TraningGame.Module.CheckSystem;
using Pendopo.TraningGame.Module.CameraHandler;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        GUI_MassCheckController massCheck;
        QueueSystemController queueSystem;
        GUI_IngredientCheckController ingredientCheck;
        ApproveDenyController approveDeny;
        CameraHandlerController cameraHandler;

        public override string SceneName { get { return GameScene.GamePlay; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new GUI_IngredientCheckConnector(),
                new GUI_MassCheckConnector(),
                new CheckSystemConnector(),
                new CameraHandlerConnector(),
                new QueueSystemConnector()

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new GUI_IngredientCheckController(),
               new GUI_MassCheckController(),
                new ApproveDenyController(),
                new CheckSystemController(),
                new CameraHandlerController(),
                new QueueSystemController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            ingredientCheck.SetView(_view.ingredientCheck);
            massCheck.SetView(_view.massCheck);
            approveDeny.SetView(_view.approveDeny);
            queueSystem.SetView(_view.queueSystem);
            cameraHandler.SetView(_view.cameraHandler);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}