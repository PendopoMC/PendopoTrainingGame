using UnityEngine.Events;
using Agate.MVC.Base;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.MainMenuCanvas
{
    public class MainMenuCanvasView :BaseView
    {
        [Scene] public string sceneToLoad;
        private UnityAction onConfirmPlay;

        internal void SetCallBack(UnityAction _onplay)
        {
            onConfirmPlay = _onplay;
        }

        public void Play()
        {
            onConfirmPlay?.Invoke();
        }
    }

}
