using UnityEngine;
using TMPro;
namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class  GUI_ExpireCheckView : GUI_BaseView
    {
        public TextMeshProUGUI t_exp;


        public void SetExp(string _xp)
        {
            t_exp.text = _xp;
        }
     
      
    }


}
