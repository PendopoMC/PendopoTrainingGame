using UnityEngine;

namespace Pendopo.TraningGame.Utils.Data
{
    [CreateAssetMenu(fileName = "Cases Collection", menuName = "Case/Collection")]
    public class SO_CaseColleciton : ScriptableObject
    {
        public SO_Case[] cases;
    }
}