using Agate.MVC.Base;
using Pendopo.TraningGame.Module.GUIDataCheck;
using Pendopo.TraningGame.Module.IngredientCheck;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;
using Pendopo.TraningGame.Module.CameraHandler;
using Pendopo.TraningGame.Module.Rotate;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public  GUI_DataCheckView expireCheck;
        public GUI_IngredientCheckView ingredientCheck;
        public GUI_MassCheckView massCheck;
        public QueueSystemView queueSystem;
        public ApproveDenyView approveDeny;
        public CameraHandlerView cameraHandler;
        public RotateSystemView rotateHandler;
    }
}