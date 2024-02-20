using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
namespace Pendopo.TraningGame.Module.CameraHandler
{
    public class CameraHandlerController : ObjectController<CameraHandlerController,CameraHandlerView>
    {
        public override void SetView(CameraHandlerView view)
        {
            base.SetView(view);
            view.Initialize();
        }
        public void FocusToObject(FocusObjectMessage _message)
        {
            _view.VCam.Follow = _message.objectToFocus.transform;
            _view.VCam.LookAt = _message.objectToFocus.transform;
            _view.CinemachineTransposer.m_BindingMode = _message.isContainer ? CinemachineTransposer.BindingMode.WorldSpace : CinemachineTransposer.BindingMode.LockToTargetWithWorldUp;
            _view.VCam.m_Lens.FieldOfView = _message.isContainer ? _view.defaultFOV : _view.zoomFOV;
        }
    }
}