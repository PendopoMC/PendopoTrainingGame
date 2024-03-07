using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;

namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class GUI_ExpireCheckConnector : BaseConnector
    {
        GUI_ExpireCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetExpireMessage>(_controller.SetMessage);
            Subscribe<SetActivetExpireMessage>(_controller.SetActive);
            //Subscribe<PointClick_EXPMessage>(_controller.OnOpenEXP);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetExpireMessage>(_controller.SetMessage);
            Unsubscribe<SetActivetExpireMessage>(_controller.SetActive);
            //Unsubscribe<PointClick_EXPMessage>(_controller.OnOpenEXP);
        }
    }
}