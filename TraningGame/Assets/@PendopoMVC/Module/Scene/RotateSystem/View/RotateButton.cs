using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Pendopo.TraningGame.Module.Rotate
{
    public class RotateButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public UnityEvent onPointerDown;
        private bool isDown;
        public void OnPointerDown(PointerEventData eventData)
        {
            isDown = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isDown = false;
        }

        private void Update()
        {
            if (!isDown) return;
            onPointerDown?.Invoke();
        }
    }
}