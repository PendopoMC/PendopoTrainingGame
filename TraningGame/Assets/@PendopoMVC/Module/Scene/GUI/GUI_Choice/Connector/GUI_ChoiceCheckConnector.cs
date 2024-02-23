using Agate.MVC.Base;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.ChoiceCheck
{
    public class GUI_ChoiceCheckConnector : BaseConnector
    {
        GUI_ChoiceCheckController _controller;
        protected override void Connect()
        {
            Subscribe<SetChoiceLogoMessage>(_controller.SetMessage);
            Subscribe<SetActiveChoiceLogoMessage>(_controller.SetActive);
            //Subscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetChoiceLogoMessage>(_controller.SetMessage);
            Unsubscribe<SetActiveChoiceLogoMessage>(_controller.SetActive);
            //Unsubscribe<PointClick_MassMessage>(_controller.OnOpenGUI);
        }
    }
}