using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using TMPro;
namespace Pendopo.TraningGame.Module.GUIRuleBook
{
    public class GUI_RuleBookView : BaseView
    {
        [SerializeField] private GameObject hud;
        public GameObject[] pages;
        UnityAction nextAction, prevAction;

        public void AssignListner(UnityAction nextAction, UnityAction prevAction)
        {
            this.nextAction = nextAction;
            this.prevAction = prevAction;
        }
        public void Next()
        {
            nextAction?.Invoke();
        }

        public void Previous()
        {
            prevAction?.Invoke();
        }

        public void OpenHUD()
        {
            hud.SetActive(!hud.activeInHierarchy);
        }
    }
}
