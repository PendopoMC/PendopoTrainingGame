using UnityEngine;
using TMPro;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Module.MassCheck
{
    public class GUI_MassCheckView :BaseView
    {
        [SerializeField] private TextMeshProUGUI t_mass;
        [SerializeField] private GameObject hud;

        public void SetMass(string _message)
        {
            t_mass.text = _message;
        }
        public void SetActive()
        {
            hud.SetActive(!hud.activeInHierarchy);
        }
    }
}