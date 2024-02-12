﻿using UnityEngine;

namespace Pendopo.TraningGame.Utils.Data
{
    [CreateAssetMenu(fileName = "Case", menuName = "Case/CaseItem")]
    public class SO_Case: ScriptableObject
    {
        public CaseType type;
        public ObjectData objectData;
        public ObjectData caseData;
        public bool finalAssesment;
    }
}