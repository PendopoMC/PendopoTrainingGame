using Agate.MVC.Base;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.ProductionCodeCheck;
using Pendopo.TraningGame.Module.Date;
using Pendopo.TraningGame.Module.WarningCheck;
using Pendopo.TraningGame.Module.GUIMission;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;
using Pendopo.TraningGame.Module.CameraHandler;
using Pendopo.TraningGame.Module.Rotate;
using Pendopo.TraningGame.Module.TimeAttack;
using Pendopo.TraningGame.Module.ObjectPool;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public GUI_MassCheckView massCheck;
        public QueueSystemView queueSystem;
        public ApproveDenyView approveDeny;
        public CameraHandlerView cameraHandler;
        public RotateSystemView rotateHandler;
        public TimeAttackView timeAttackHandler;
        public GUI_MissionView missionView;
        public GUI_ProductionCodeView productionCodeView;
        public GUI_DateView dateView;
        public GUI_WarningCheckView warningCheckView;
        public ObjectPoolerview objectPoolerview;
    }
}