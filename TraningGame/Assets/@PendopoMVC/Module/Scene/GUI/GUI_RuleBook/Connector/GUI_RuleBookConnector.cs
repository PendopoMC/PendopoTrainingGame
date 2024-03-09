using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.GUIRuleBook
{
    public class GUI_RuleBookConnector : BaseConnector
    {
        GUI_RuleBookController controller;
        protected override void Connect()
        {
            Subscribe<MissionCallbackMessage>(controller.MissionCallback);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MissionCallbackMessage>(controller.MissionCallback);
        }
    }
}
