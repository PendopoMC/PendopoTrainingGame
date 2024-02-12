using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.ApproveDeny
{
    public class ApproveDenyController : ObjectController<ApproveDenyController, ApproveDenyView>
    {
        ApproveMessage approve = new ApproveMessage();
        DeniedMessage deny = new DeniedMessage();
        public override void SetView(ApproveDenyView view)
        {
            base.SetView(view);
            _view.SetCallback(delegate { Approve(); }, delegate { Deny(); });
        }

        private void Approve()
        {
            Publish<ApproveMessage>(approve);

        }
        private void Deny()
        {
            Publish<DeniedMessage>(deny);
        }

    }
}
