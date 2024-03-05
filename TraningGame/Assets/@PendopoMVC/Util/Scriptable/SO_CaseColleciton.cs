using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Pendopo.TraningGame.Utils.Data
{
    [CreateAssetMenu(fileName = "Cases Collection", menuName = "Case/Collection")]
    public class SO_CaseColleciton : ScriptableObject
    {
        public List<ObjectData> csv_cases = new List<ObjectData>();
        public List<LevelCase> csv_level = new List<LevelCase>();
    }
}