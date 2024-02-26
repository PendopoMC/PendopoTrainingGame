using UnityEngine.Events;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.Rotate
{
    public class RotateSystemView : BaseView
    {
        private UnityAction rotateUp, rotateDown, rotateLeft, rotateRight;
       

        public void SetCallback(UnityAction _rotateUp, UnityAction _rotateDown, UnityAction _rotateLeft, UnityAction _rotateRight)
        {
            rotateUp = _rotateUp;
            rotateDown = _rotateDown;
            rotateLeft = _rotateLeft;
            rotateRight = _rotateRight;
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
    }
}