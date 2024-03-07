using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.GUIMission
{
    public class GUI_MissionConnector : BaseConnector
    {
        GUI_MissionController controller;
        protected override void Connect()
        {
            Subscribe<MissionCallbackMessage>(controller.MissionCallback);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MissionCallbackMessage>(controller.MissionCallback);
        }
    }
}
