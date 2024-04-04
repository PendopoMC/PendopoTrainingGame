using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.Date
{
    public class GUI_DateConnector : BaseConnector
    {
        GUI_DateController _controller;
        protected override void Connect()
        {
            Subscribe<SetDateMessage>(_controller.SetMessage);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetDateMessage>(_controller.SetMessage);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}