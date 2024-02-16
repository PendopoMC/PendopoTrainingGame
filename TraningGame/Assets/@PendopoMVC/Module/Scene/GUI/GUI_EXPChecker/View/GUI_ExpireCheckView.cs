using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class  GUI_ExpireCheckView : BaseView
    {
        [SerializeField] private TextMeshProUGUI t_exp;
        [SerializeField] private GameObject hud;
        [SerializeField] private Vector2 onPosition;
        [SerializeField] private Vector2 offPosition;

        public void SetExp(string _xp)
        {
            t_exp.text = _xp;
        }
        public void SetActive()
        {
            hud.SetActive(!hud.activeInHierarchy);
        }
        public void SetActive(bool _flag)
        {
            hud.SetActive(_flag);
        }
    }

}