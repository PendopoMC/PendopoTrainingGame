using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.StrawCheck
{
    public class GUI_StrawCheckConnector : BaseConnector
    {
        GUI_StrawCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetMassMessage>(_controller.SetMessage);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetMassMessage>(_controller.SetMessage);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}