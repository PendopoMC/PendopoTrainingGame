using Agate.MVC.Base;
using Pendopo.TraningGame.Module.ExpireCheck;
using Pendopo.TraningGame.Module.IngredientCheck;
using Pendopo.TraningGame.Module.MassCheck;
using Pendopo.TraningGame.Module.QueueSystem;

namespace Pendopo.TraningGame.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public ExpireCheckView expireCheck;
        public IngredientCheckView ingredientCheck;
        public MassCheckView massCheck;
        public QueueSystemView queueSystem;
    }
}