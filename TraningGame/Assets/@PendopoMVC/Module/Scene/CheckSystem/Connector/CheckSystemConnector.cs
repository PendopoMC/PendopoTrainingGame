using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public class CheckSystemConnector : BaseConnector
    {
        CheckSystemController checkSystemController;
        protected override void Connect()
        {
            Subscribe<CompareCheck>(checkSystemController.Compare);
        }

        protected override void Disconnect()
        {
            Unsubscribe<CompareCheck>(checkSystemController.Compare);
        }
    }
}