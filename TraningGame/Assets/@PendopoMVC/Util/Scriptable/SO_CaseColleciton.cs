using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Pendopo.TraningGame.Utils.Data
{
    [CreateAssetMenu(fileName = "Cases Collection", menuName = "Case/Collection")]
    public class SO_CaseColleciton : ScriptableObject
    {
        public SO_Case[] cases;
        public List<Case> csv_cases = new List<Case>();
    }
}