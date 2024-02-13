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
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetMassMessage>(_controller.OnMassCheckMessage);
        }
    }
}