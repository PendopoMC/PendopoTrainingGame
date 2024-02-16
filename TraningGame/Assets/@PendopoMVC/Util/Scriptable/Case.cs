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
        public string prefabObject;
        public string expire;
        public string ingredients;
        public string mass;
        public string color;
        public string productName;
        public string productionCode;
        public string barCode;
        public string QRCode;
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
        Color,
        Production_Code,
        Bar_Code,
        QR_Code,
        Product_Name
    }


    public struct CheckCaseNonText
    {
        public Sprite spriteToCheck;
    }

    public struct CheckCaseText
    {
        public string textToCheck;
    }
}