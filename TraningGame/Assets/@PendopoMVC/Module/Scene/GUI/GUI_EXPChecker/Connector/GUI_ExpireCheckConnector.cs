using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class GUI_ExpireCheckConnector : BaseConnector
    {
        GUI_ExpireCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetExpireMessage>(_controller.SetMessage);
            //Subscribe<PointClick_EXPMessage>(_controller.OnOpenEXP);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetExpireMessage>(_controller.SetMessage);
            //Unsubscribe<PointClick_EXPMessage>(_controller.OnOpenEXP);
        }
    }
}