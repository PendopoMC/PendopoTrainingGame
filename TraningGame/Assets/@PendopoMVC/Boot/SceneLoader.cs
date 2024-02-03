using Agate.MVC.Base;

namespace Pendopo.TraningGame.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => GameScene.SplashScreen;
    }
}