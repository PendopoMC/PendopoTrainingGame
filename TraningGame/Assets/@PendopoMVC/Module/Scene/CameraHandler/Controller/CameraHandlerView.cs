using Agate.MVC.Base;
using Cinemachine;
namespace Pendopo.TraningGame.Module.CameraHandler
{
    public class CameraHandlerView:BaseView
    {
        private CinemachineVirtualCamera vCam;
        private CinemachineTransposer cinemachineTransposer;
        public float defaultFOV=60, zoomFOV=25;

        public CinemachineVirtualCamera VCam { get => vCam; private set => vCam = value; }
        public CinemachineTransposer CinemachineTransposer { get => cinemachineTransposer; private set => cinemachineTransposer = value; }

        public void Initialize()
        {
            VCam = GetComponent<CinemachineVirtualCamera>();
            CinemachineTransposer = VCam.GetCinemachineComponent<CinemachineTransposer>();
        }
    }   
}