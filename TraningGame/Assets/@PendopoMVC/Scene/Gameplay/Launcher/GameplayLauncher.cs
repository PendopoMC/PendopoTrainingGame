using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Boot;
using Pendopo.TraningGame.Module.ExpireCheck;
using Pendopo.TraningGame.Module.IngredientCheck;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        ExpireCheckController expireCheck;
        MassCheckController massCheck;
        QueueSystemController queueSystem;
        IngredientCheckController ingredientCheck;
        ApproveDenyController approveDeny;
        public override string SceneName { get { return GameScene.GamePlay; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new ExpireCheckConnector(),
                new IngredientCheckConnector(),
                new MassCheckConnector(),
                new QueueSystemConnector()

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                    new ExpireCheckController(),
                new MassCheckController(),
                new IngredientCheckController(),
                new ApproveDenyController(),
                new QueueSystemController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            expireCheck.SetView(_view.expireCheck);
            massCheck.SetView(_view.massCheck);
            ingredientCheck.SetView(_view.ingredientCheck);
            approveDeny.SetView(_view.approveDeny);
            queueSystem.SetView(_view.queueSystem);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}