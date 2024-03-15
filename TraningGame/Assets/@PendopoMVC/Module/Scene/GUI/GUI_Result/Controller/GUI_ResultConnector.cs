using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.GUIResult
{
    public class GUI_ResultConnector : BaseConnector
    {
        GUI_ResultController resultController;
        protected override void Connect()
        {
            Subscribe<ShowResult>(resultController.ShowResult);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowResult>(resultController.ShowResult);
        }
    }
}
