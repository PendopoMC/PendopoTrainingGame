using UnityEngine;
using TMPro;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.MassCheck
{
    public class MassCheckView :BaseView
    {
        [SerializeField] private TextMeshProUGUI t_mass;

        public void SetMass(string _message)
        {
            t_mass.text = _message;
        }
    }
}