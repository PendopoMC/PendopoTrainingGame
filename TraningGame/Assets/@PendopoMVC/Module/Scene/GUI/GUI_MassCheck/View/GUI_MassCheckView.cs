using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Agate.MVC.Base;
using NaughtyAttributes;

namespace Pendopo.TraningGame.Module.MassCheck
{
    public class GUI_MassCheckView : GUI_BaseView
    {
        public TextMeshProUGUI t_mass;

        public void SetMass(string _message)
        {
            t_mass.text = _message;
        }
    }
}