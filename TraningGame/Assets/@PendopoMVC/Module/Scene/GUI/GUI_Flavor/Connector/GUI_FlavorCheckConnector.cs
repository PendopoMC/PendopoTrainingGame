using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.FlavorCheck
{
    public class GUI_FlavorCheckConnector : BaseConnector
    {
        GUI_FlavorCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetFlavorMessage>(_controller.SetMessage);
            Subscribe<SetActivetFlavorMessage>(_controller.SetActive);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetFlavorMessage>(_controller.SetMessage);
            Unsubscribe<SetActivetFlavorMessage>(_controller.SetActive);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}