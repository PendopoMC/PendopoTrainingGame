using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.FlavorCheck
{
    public class GUI_FlavorCheckConnector : BaseConnector
    {
        GUI_FlavorCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetTasteMessage>(_controller.SetMessage);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetTasteMessage>(_controller.SetMessage);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}