using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.GUIDataCheck
{
    public class  GUI_DataCheckView : BaseView
    {
        public Image i_data;
        public TextMeshProUGUI t_data;

        [SerializeField] private RectTransform hud;
        //[SerializeField] private Vector2 onPosition;
        //[SerializeField] private Vector2 offPosition;
        //private bool isOpen = false;
        internal UnityAction publishMessage;

        public void SetActive(bool _flag)
        {
            hud.gameObject.SetActive(_flag);
        }
        public void CheckSegment()
        {
            publishMessage?.Invoke();
        }

        public virtual void SetData(string _data)
        {
            t_data.text = _data;
        }

        public virtual void SetData(Sprite _sprite)
        {
            i_data.sprite = _sprite;
        }

        //[Button("On Pos")]
        //private void AddOnPos()
        //{
        //    onPosition = hud.anchoredPosition;
        //}

        //[Button("Off Pos")]
        //private void AddOffPos()
        //{
        //    offPosition = hud.anchoredPosition;
        //}
      
    }


}
