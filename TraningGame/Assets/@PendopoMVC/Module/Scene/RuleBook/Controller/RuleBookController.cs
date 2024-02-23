using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using NaughtyAttributes;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;

namespace Pendopo.TraningGame.Module.RuleBook
{
    public class RuleBookController : ObjectController<RuleBookController,RuleBookModel,IRuleBookModel,RuleBookView>
    {
        public override void SetView(RuleBookView view)
        {
            base.SetView(view);
            _model.SetHUD(view.hud);
            SetCallback();
        }


        private void SetCallback()
        {
            _view.onOpenClick += delegate
            {
                _view.hud.SetActive(!_view.hud.activeInHierarchy);
            };
        }
    }

    public class RuleBookView : ObjectView<IRuleBookModel>
    {
        public GameObject hud;
        internal UnityAction onOpenClick;

        protected override void InitRenderModel(IRuleBookModel model)
        {
        }

        protected override void UpdateRenderModel(IRuleBookModel model)
        {
        }


        public void OpenHUD()
        {
            onOpenClick?.Invoke();
        }
    }

    public class RuleBookModel : BaseModel, IRuleBookModel
    {
        public ObjectData data { get; private set; }
        public GameObject hud { get; private set; }

        public void SetHUD(GameObject _go)
        {
            hud = _go;
        }
    }

    public interface IRuleBookModel : IBaseModel
    {
        public GameObject hud { get; }
        public ObjectData data { get; }
    }

    public class RuleBookConnector : BaseConnector
    {
        protected override void Connect()
        {
        }

        protected override void Disconnect()
        {
        }
    }
}