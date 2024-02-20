using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.MassCheck
{
    public class GUI_MassCheckConnector : BaseConnector
    {
        GUI_MassCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetMassMessage>(_controller.OnMassCheckMessage);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetMassMessage>(_controller.OnMassCheckMessage);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}