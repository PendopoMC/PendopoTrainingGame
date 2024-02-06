using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class ExpireCheckView : BaseView
    {
        [SerializeField] private TextMeshProUGUI t_exp;


        public void SetExp(string _xp)
        {
            t_exp.text = _xp;
        }
    }

}