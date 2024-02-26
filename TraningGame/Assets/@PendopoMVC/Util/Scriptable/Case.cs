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
        public ObjectData objectData;
        public ObjectData caseData;
        public bool finalAssesment;

        public void SetData(int _id, string _data,bool _isObject)
        {
            if (_isObject)
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
            else
            {
                switch ((CheckType)(_id - 18))
                {
                    case CheckType.Package:
                        caseData.package = _data;
                        break;
                    case CheckType.EXP:
                        caseData.EXP = _data;
                        break;
                    case CheckType.komposisiInd:
                        caseData.komposisiInd = _data;
                        break;
                    case CheckType.komposisiEng:
                        caseData.komposisiEng = _data;
                        break;
                    case CheckType.berat:
                        caseData.berat = _data;
                        break;
                    case CheckType.logoHalal:
                        caseData.logoHalal = _data;
                        break;
                    case CheckType.contact:
                        caseData.contact = _data;
                        break;
                    case CheckType.kodeProduksi:
                        caseData.kodeProduksi = _data;
                        break;
                    case CheckType.barCode:
                        caseData.barCode = _data;
                        break;
                    case CheckType.QRCode:
                        caseData.QRCode = _data;
                        break;
                    case CheckType.seal:
                        caseData.seal = _data;
                        break;
                    case CheckType.sedotan:
                        caseData.sedotan = _data;
                        break;
                    case CheckType.logoRecycle:
                        caseData.logoRecycle = _data;
                        break;
                    case CheckType.rasa:
                        caseData.rasa = _data;
                        break;
                    case CheckType.rasaGambar:
                        caseData.rasaGambar = _data;
                        break;
                    case CheckType.logoPilihan:
                        caseData.logoPilihan = _data;
                        break;
                    case CheckType.peringatan:
                        caseData.peringatan = _data;
                        break;
                    case CheckType.nutritionFact:
                        caseData.nutritionFact = _data;
                        break;
                    default:
                        break;
                }
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

    public enum CaseType
    {
        Order,
        Disorder
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