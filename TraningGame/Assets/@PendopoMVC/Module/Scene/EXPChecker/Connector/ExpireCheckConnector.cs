using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class ExpireCheckConnector : BaseConnector
    {
        ExpireCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetExpireMessage>(_controller.OnEXPMessage);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetExpireMessage>(_controller.OnEXPMessage);
        }
    }

}