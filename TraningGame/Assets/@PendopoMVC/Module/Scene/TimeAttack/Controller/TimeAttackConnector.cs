using Pendopo.TraningGame.Message;
using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.TimeAttack
{
    public class TimeAttackConnector : BaseConnector
    {
        TimeAttackController controller;
        protected override void Connect()
        {
            Subscribe<StartTimeAttack>(controller.StartTimeAttack);
            Subscribe<StopOrResumeTimeAttack>(controller.StopOrResumeTimeAttack);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartTimeAttack>(controller.StartTimeAttack);
            Unsubscribe<StopOrResumeTimeAttack>(controller.StopOrResumeTimeAttack);
        }
    }


}