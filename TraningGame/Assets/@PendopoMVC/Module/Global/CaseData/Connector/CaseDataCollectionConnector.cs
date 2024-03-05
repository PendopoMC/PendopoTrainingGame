using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Global.CaseDataCollection
{
    public class CaseDataCollectionConnector : BaseConnector
    {
        CaseDataCollectionController controller;
        protected override void Connect()
        {
            Subscribe<RequestCase>(controller.GetCaseQueue);
        }

        protected override void Disconnect()
        {
            Unsubscribe<RequestCase>(controller.GetCaseQueue);
        }
    }

}