using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemConnector : BaseConnector
    {
        private QueueSystemController _queueSystem;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_queueSystem.StartGame);
            Subscribe<ApproveMessage>(_queueSystem.OnApprove);
            Subscribe<DeniedMessage>(_queueSystem.OnDenied);
            Subscribe<GameOverMessage>(_queueSystem.Gameover);
            Subscribe<RotateMessage>(_queueSystem.RotateObject);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_queueSystem.StartGame);
            Unsubscribe<ApproveMessage>(_queueSystem.OnApprove);
            Unsubscribe<DeniedMessage>(_queueSystem.OnDenied);
            Unsubscribe<GameOverMessage>(_queueSystem.Gameover);
            Subscribe<RotateMessage>(_queueSystem.RotateObject);
        }
    }
}