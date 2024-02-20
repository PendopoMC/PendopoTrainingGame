using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public class CheckSystemConnector : BaseConnector
    {
        CheckSystemController checkSystemController;
        protected override void Connect()
        {
            Subscribe<CheckCaseText>(checkSystemController.OnCaseTextCheck);
            Subscribe<CheckCaseNonText>(checkSystemController.OnCaseNonTextCheck);
        }

        protected override void Disconnect()
        {
            Unsubscribe<CheckCaseText>(checkSystemController.OnCaseTextCheck);
            Unsubscribe<CheckCaseNonText>(checkSystemController.OnCaseNonTextCheck);
        }
    }
}