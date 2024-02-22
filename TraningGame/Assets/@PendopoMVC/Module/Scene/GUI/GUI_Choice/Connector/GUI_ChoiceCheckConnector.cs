using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.ChoiceCheck
{
    public class GUI_ChoiceCheckConnector : BaseConnector
    {
        GUI_ChoiceCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetFlavorMessage>(_controller.SetMessage);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetFlavorMessage>(_controller.SetMessage);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}