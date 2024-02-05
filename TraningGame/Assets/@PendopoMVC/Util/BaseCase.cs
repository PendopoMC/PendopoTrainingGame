using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Pendopo.TraningGame.Utils.Data
{
    public abstract class BaseCase
    {
        public CaseType type;
        public string prefabObject;
        public StepPair stepPair;
        public bool finalAssesment;
    }

    public class StepCase : BaseCase
    {
        public StepPair[] stepPairs;
    }

    public enum CaseType
    {
        Order,
        Disorder
    }

    [System.Serializable]
    public class StepPair
    {
        public string gameplayName;
        public string objValue;
        public string trueValue;


        public bool FinalValue()
        {
            return objValue == trueValue;
        }
    }

}