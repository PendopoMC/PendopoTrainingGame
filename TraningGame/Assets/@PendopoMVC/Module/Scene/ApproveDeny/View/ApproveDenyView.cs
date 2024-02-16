using UnityEngine.Events;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.ApproveDeny
{
    public class ApproveDenyView : BaseView
    {
        private UnityAction onApprove, onDeny;

        public void SetCallback(UnityAction _approve, UnityAction _deny)
        {
            onApprove = _approve;
            onDeny = _deny;
        }

        public void Approve()
        {
            onApprove?.Invoke();
        }
        public void Deny()
        {
            onDeny?.Invoke();
        }
    }
}
