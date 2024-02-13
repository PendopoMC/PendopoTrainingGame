using Agate.MVC.Base;
using Pendopo.TraningGame.Module.ExpireCheck;
using Pendopo.TraningGame.Module.IngredientCheck;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;
using Pendopo.TraningGame.Module.ApproveDeny;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public  GUI_ExpireCheckView expireCheck;
        public GUI_IngredientCheckView ingredientCheck;
        public GUI_MassCheckView massCheck;
        public QueueSystemView queueSystem;
        public ApproveDenyView approveDeny;
    }
}