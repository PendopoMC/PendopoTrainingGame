using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Global.ProgressionData
{
    public class ProgressionDataConnector : BaseConnector
    {
        ProgressionDataController controller;
        protected override void Connect()
        {
            Subscribe<AddProgressionAprrove>(controller.AddProgressApprove);
            Subscribe<AddProgressionReject>(controller.AddProgressReject);
            Subscribe<ResetProgression>(controller.ResetProgress);
            Subscribe<SetScore>(controller.AddScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AddProgressionAprrove>(controller.AddProgressApprove);
            Unsubscribe<AddProgressionReject>(controller.AddProgressReject);
            Unsubscribe<ResetProgression>(controller.ResetProgress);
            Unsubscribe<SetScore>(controller.AddScore);
        }
    }

}
