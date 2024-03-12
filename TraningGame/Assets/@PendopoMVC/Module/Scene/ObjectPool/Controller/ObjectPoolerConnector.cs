using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.ObjectPool
{
    public class ObjectPoolerConnector : BaseConnector
    {
        ObjectPoolerController controller;
        protected override void Connect()
        {
            Subscribe<RequestObject>(controller.GetObject);
            Subscribe<RequestReturnObject>(controller.ReturnObject);
        }

        protected override void Disconnect()
        {
            Unsubscribe<RequestObject>(controller.GetObject);
            Unsubscribe<RequestReturnObject>(controller.ReturnObject);
        }
    }

}