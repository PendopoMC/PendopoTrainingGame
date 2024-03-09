using UnityEngine.Events;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.Rotate
{
    public class RotateSystemView : BaseView
    {
        public float speedRotation =5f;
        private UnityAction rotateUp, rotateDown, rotateLeft, rotateRight,resetRotation,rotateInput;


        public void SetCallback(UnityAction _rotateInput,UnityAction _resetRotation)
        {
            rotateInput = _rotateInput;
            resetRotation = _resetRotation;
        }

        private void Update()
        {
            rotateInput?.Invoke();
        }

        public void RotateLeft()
        {
            rotateLeft?.Invoke();
        }

        public void RotateRight()
        {
            rotateRight?.Invoke();
        }

        public void RotateUp()
        {
            rotateUp?.Invoke();
        }
        
        public void RotateDown()
        {
            rotateDown?.Invoke();
        }

        public void ResetRotation()
        {
            resetRotation?.Invoke();
        }
    }
}