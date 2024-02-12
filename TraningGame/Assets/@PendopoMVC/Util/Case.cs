using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

namespace Pendopo.TraningGame.Utils.Data
{
    [System.Serializable]
    public class Case
    {
        public CaseType type;
        public ObjectData objectData;
        public ObjectData caseData;
        public bool finalAssesment;
    }

    [System.Serializable]
    public struct ObjectData
    {
        public string prefabObject;
        public string expire;
        public string ingredients;
        public string mass;
        public bool damaged;
    }

    public enum CaseType
    {
        Order,
        Disorder
    }

    [System.Serializable]
    public class ComparePair : BasePair<ComparePair>
    {
        public string objValue;
        public string trueValue;


        public override bool FinalValue()
        {
            return objValue == trueValue;
        }
    }



    public abstract class BasePair<T> where T:class
    {
        public T pair;
        public abstract bool FinalValue();
    }
}