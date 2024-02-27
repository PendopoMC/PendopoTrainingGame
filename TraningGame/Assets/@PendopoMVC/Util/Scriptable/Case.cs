using System;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

namespace Pendopo.TraningGame.Utils.Data
{
    [System.Serializable]
    public class Case
    {
        public ObjectData objectData;
        public bool finalAssesment;
 
        public void SetData(int _id, string _data)
        {
            switch ((CheckType)_id)
            {
                case CheckType.Package:
                    objectData.package = _data;
                    break;
                case CheckType.EXP:
                    objectData.EXP = _data;
                    break;
                case CheckType.komposisiInd:
                    objectData.komposisiInd = _data;
                    break;
                case CheckType.komposisiEng:
                    objectData.komposisiEng = _data;
                    break;
                case CheckType.berat:
                    objectData.berat = _data;
                    break;
                case CheckType.logoHalal:
                    objectData.logoHalal = _data;
                    break;
                case CheckType.contact:
                    objectData.contact = _data;
                    break;
                case CheckType.kodeProduksi:
                    objectData.kodeProduksi = _data;
                    break;
                case CheckType.barCode:
                    objectData.barCode = _data;
                    break;
                case CheckType.QRCode:
                    objectData.QRCode = _data;
                    break;
                case CheckType.seal:
                    objectData.seal = _data;
                    break;
                case CheckType.sedotan:
                    objectData.sedotan = _data;
                    break;
                case CheckType.logoRecycle:
                    objectData.logoRecycle = _data;
                    break;
                case CheckType.rasa:
                    objectData.rasa = _data;
                    break;
                case CheckType.rasaGambar:
                    objectData.rasaGambar = _data;
                    break;
                case CheckType.logoPilihan:
                    objectData.logoPilihan = _data;
                    break;
                case CheckType.peringatan:
                    objectData.peringatan = _data;
                    break;
                case CheckType.nutritionFact:
                    objectData.nutritionFact = _data;
                    break;
                default:
                    break;
            }

        }
    }


    [System.Serializable]
    public struct LevelCase
    {
        public int id;
        public string rule;
        public int QC_ID_Start, QC_ID_End;
        public ObjectData caseData;

        public struct LevelCaseBuilder
        {
            private int id;
            private string rule;
            private int QC_ID_Start, QC_ID_End;
            private ObjectData caseData;

            private Dictionary<string, string> pairValue;
            public void SetValueByName(string variableName, object value)
            {
                // Get the type of this class
                Type type = this.GetType();

                // Get the field info based on the variableName
                FieldInfo field = type.GetField(variableName, BindingFlags.NonPublic | BindingFlags.Instance);

                // If the field is found, set its value
                if (field != null)
                {
                    field.SetValue(this, value);
                    Console.WriteLine($"Value {value} set to variable {variableName}");
                }
                else
                {
                    Console.WriteLine($"Variable {variableName} not found.");
                }
            }
            public LevelCaseBuilder Initialze()
            {
                pairValue = new Dictionary<string, string>();
              
                return this;
            }

            public LevelCaseBuilder SetData(int _id,string _data)
            {
              
                return this;
            }

            public LevelCaseBuilder WithID(int id)
            {
                this.id = id;
                return this;
            }   
          
            public LevelCaseBuilder WithRule(string rule)
            {
                this.rule = rule;
                return this;
            }  
            
            public LevelCaseBuilder WithStartAndEnd(int start,int end)
            {
                QC_ID_Start = start;
                QC_ID_End = end;
                return this;
            }   
            
            public LevelCaseBuilder WithObjData(ObjectData caseData)
            {
                this.caseData = caseData;
                return this;
            }

            public LevelCase Build()
            {
                LevelCase _newLevelCase = new LevelCase();
                _newLevelCase.caseData = caseData;
                _newLevelCase.id = id;
                _newLevelCase.QC_ID_End = QC_ID_End;
                _newLevelCase.QC_ID_Start = QC_ID_Start;
                _newLevelCase.rule = rule;

                return _newLevelCase;
            }
        }
    }


    [System.Serializable]
    public struct ObjectData
    {
        public string package;
        public string EXP;
        public string komposisiInd;
        public string komposisiEng;
        public string berat;
        public string logoHalal;
        public string contact;
        public string kodeProduksi;
        public string barCode;
        public string QRCode;
        public string seal;
        public string sedotan;
        public string logoRecycle;
        public string rasa;
        public string rasaGambar;
        public string logoPilihan;
        public string peringatan;
        public string nutritionFact;
    }

    public enum CheckType
    {
        Package,
        EXP,
        komposisiInd,
        komposisiEng,
        berat,
        logoHalal,
        contact,
        kodeProduksi,
        barCode,
        QRCode,
        seal,
        sedotan,
        logoRecycle,
        rasa,
        rasaGambar,
        logoPilihan,
        peringatan,
        nutritionFact
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