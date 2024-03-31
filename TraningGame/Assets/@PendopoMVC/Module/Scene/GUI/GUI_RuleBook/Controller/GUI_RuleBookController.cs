using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using UnityEngine.InputSystem.iOS;
namespace Pendopo.TraningGame.Module.GUIRuleBook
{

    public class GUI_RuleBookController : ObjectController<GUI_RuleBookController,GUI_RuleBookView>
    {

        int currentIndex;
        public override void SetView(GUI_RuleBookView view)
        {
            base.SetView(view);
            currentIndex = 0;
            _view.AssignListner(Next, Previous);
        }


        private void Next()
        {
            currentIndex++;
            foreach (var item in _view.pages)
            {
                item.SetActive(false); 
            }
            _view.pages[currentIndex].SetActive(true);
        }

        private void Previous()
        {
            currentIndex--; foreach (var item in _view.pages)
            {
                item.SetActive(false);
            }
            _view.pages[currentIndex].SetActive(true);
        }

    }
}