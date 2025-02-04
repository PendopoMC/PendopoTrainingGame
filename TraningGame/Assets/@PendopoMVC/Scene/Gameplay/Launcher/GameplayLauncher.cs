using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Boot;
using Pendopo.TraningGame.Module.ProductionCodeCheck;
using Pendopo.TraningGame.Module.Date;
using Pendopo.TraningGame.Module.GUIMission;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;
using Pendopo.TraningGame.Module.CheckSystem;
using Pendopo.TraningGame.Module.CameraHandler;
using Pendopo.TraningGame.Module.Rotate;
using Pendopo.TraningGame.Module.WarningCheck;
using Pendopo.TraningGame.Module.TimeAttack;
using Pendopo.TraningGame.Module.ObjectPool;
using Pendopo.TraningGame.Global.CaseDataCollection;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        GUI_MassCheckController massCheck;
        QueueSystemController queueSystem;
        ApproveDenyController approveDeny;
        CameraHandlerController cameraHandler;
        RotateSystemController rotateHandler;
        TimeAttackController timeAttackHandler;
        GUI_DateController dateController;
        GUI_ProductionCodeController productionCodeController;
        GUI_WarningCheckController warningCheckController;
        GUI_MissionController missionController;
        ObjectPoolerController poolerController;
        CaseDataCollectionController caseDataController;

        public override string SceneName { get { return GameScene.GamePlay; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new CaseDataCollectionConnector(),
                new ObjectPoolerConnector(),
                new GUI_MassCheckConnector(),
                new CheckSystemConnector(),
                new CameraHandlerConnector(),
                new TimeAttackConnector(),
                new GUI_MissionConnector(),
                new GUI_DateConnector(),
                new GUI_ProductionCodeConnector(),
                new GUI_WarningCheckConnector(),
                new QueueSystemConnector()

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                  new CaseDataCollectionController(),
                 new ObjectPoolerController(),
               new GUI_MassCheckController(),
                new ApproveDenyController(),
                new CheckSystemController(),
                new CameraHandlerController(),
                new QueueSystemController(),
                new TimeAttackController(),
                new GUI_DateController(),
                new GUI_MissionController(),
                new GUI_ProductionCodeController(),
                new GUI_WarningCheckController(),
                 new RotateSystemController()
               
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            caseDataController.SetView(_view.caseDataView);
            dateController.SetView(_view.dateView);
            poolerController.SetView(_view.objectPoolerview);
            warningCheckController.SetView(_view.warningCheckView);
            missionController.SetView(_view.missionView);
            productionCodeController.SetView(_view.productionCodeView);
            massCheck.SetView(_view.massCheck);
            approveDeny.SetView(_view.approveDeny);
            queueSystem.SetView(_view.queueSystem);
            cameraHandler.SetView(_view.cameraHandler);
            rotateHandler.SetView(_view.rotateHandler);
            timeAttackHandler.SetView(_view.timeAttackHandler);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}