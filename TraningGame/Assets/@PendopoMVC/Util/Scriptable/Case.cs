using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

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
        public string pacakge;
        public string expire;
        public string ingredients;
        public string mass;
        public string halal;
        public string productName;
        public string productionCode;
        public string barCode;
        public string QRCode;
        public string tagLine;
        public string straw;
    }

    public enum CaseType
    {
        Order,
        Disorder
    }

    public enum CheckType
    {
        Package,
        Expire,
        Mass,
        Ingredient,
        Halal,
        NutritionFact,
        ProductionCode,
        BarCode,
        QRCode,
        ProductName,
        TagLine,
        Straw
    }

    public struct CompareCheck
    {
        public CheckType type;
        public string data;

    }

    public interface ICompareCheck
    {
        public string dat { get; }
    }
}