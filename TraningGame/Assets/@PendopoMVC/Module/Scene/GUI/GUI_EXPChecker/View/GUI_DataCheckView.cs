using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class  GUI_DataCheckView : BaseView
    {
        public Image i_data;
        public TextMeshProUGUI t_data;

        [SerializeField] private RectTransform hud;
        [SerializeField] private Vector2 onPosition;
        [SerializeField] private Vector2 offPosition;
        private bool isOpen = false;
        internal UnityAction publishMessage;

        public void SetActive()
        {
            isOpen = !isOpen;
            hud.anchoredPosition = isOpen ? onPosition : offPosition;
        }
        public void CheckSegment()
        {
            publishMessage?.Invoke();
        }

        public void SetData(string _xp)
        {
            t_data.text = _xp;
        }


        [Button("On Pos")]
        private void AddOnPos()
        {
            onPosition = hud.anchoredPosition;
        }

        [Button("Off Pos")]
        private void AddOffPos()
        {
            offPosition = hud.anchoredPosition;
        }
      
    }


}
