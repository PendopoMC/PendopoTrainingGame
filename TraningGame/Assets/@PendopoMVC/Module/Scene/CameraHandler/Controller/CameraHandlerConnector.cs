using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.CameraHandler
{
    public class CameraHandlerConnector : BaseConnector
    {
        CameraHandlerController cameraHandlerController;
        protected override void Connect()
        {
            Subscribe<FocusObjectMessage>(cameraHandlerController.FocusToObject);
        }

        protected override void Disconnect()
        {
            Unsubscribe<FocusObjectMessage>(cameraHandlerController.FocusToObject);
        }
    }
}