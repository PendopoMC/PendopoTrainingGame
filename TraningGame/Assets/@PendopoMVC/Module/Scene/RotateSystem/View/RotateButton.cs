using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
/// <summary>
/// To Do Arief : 
/// Better to create Numeration for handling the pointer event
/// </summary>

namespace Pendopo.TraningGame.Module.Rotate
{
    public class RotateButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IPointerClickHandler
    {
        public UnityEvent onPointerDown;
        public UnityEvent onPointerClick;
        private bool isDown;

        public void OnPointerClick(PointerEventData eventData)
        {
            onPointerClick?.Invoke();
        }

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