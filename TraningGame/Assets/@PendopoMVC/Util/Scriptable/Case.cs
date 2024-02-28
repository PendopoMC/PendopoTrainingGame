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
    }


    [System.Serializable]
    public class LevelCase
    {
        public int ID;
        public int QC_ID_StartValue;
        public int QC_ID_EndValue;
        public ObjectData caseData;
        private string id { get; set; }
        private string rule { get; set; }
        private string QC_ID_Start { get; set; }
        private string QC_ID_End { get; set; }
        public void SetValueByName(string propertyName, object value,bool _debug=false)
        {
            // Get the type of this class
            Type type = this.GetType();

            // Get the property info based on the propertyName
            PropertyInfo property = type.GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);

            // If the property is found, set its value
            if (property != null)
            {
                property.SetValue(this, Convert.ChangeType(value, property.PropertyType));
                if (!_debug) return;
                Debug.Log($"Value {value} set to property {propertyName}");
                Debug.Log(property.GetValue(this));
            }
            else
            {
                if (!_debug) return;
               Debug.Log($"Property {propertyName} not found.");
            }
        }
        public override string ToString()
        {
            return $"id : {id}" +
                $"rule : {rule}" +
                $"QC_ID_Start : {QC_ID_Start}" +
                $"QC_ID_Start : {QC_ID_End}";
        }

        public void Initialize(ObjectData _data)
        {
            QC_ID_StartValue = int.Parse(QC_ID_Start);
            QC_ID_EndValue = int.Parse(QC_ID_End);
            caseData = _data;
        }
    }


    [System.Serializable]
    public class ObjectData
    {
        private string Package { get; set; }
        private string EXP { get; set; }
        private string komposisiInd { get; set; }
        private string komposisiEng { get; set; }
        private string berat { get; set; }
        private string logoHalal { get; set; }
        private string contact { get; set; }
        private string kodeProduksi { get; set; }
        private string barCode { get; set; }
        private string QRCode { get; set; }
        private string seal { get; set; }
        private string sedotan { get; set; }
        private string logoRecycle { get; set; }
        private string rasa { get; set; }
        private string rasaGambar { get; set; }
        private string logoPilihan { get; set; }
        private string peringatan { get; set; }
        private string nutritionFact { get; set; }

        public string PackageName;
        public string Expire;
        public string KomposisiInd;
        public string KomposisiEng;
        public string Berat;
        public string LogoHalal;
        public string Contact;
        public string KodeProduksi;
        public string BarCode;
        public string QRCodeLogo;
        public string Seal;
        public string Sedotan;
        public string LogoRecycle;
        public string Rasa;
        public string RasaGambar;
        public string LogoPilihan;
        public string Peringatan;
        public string NutritionFact;

        public void SetValueByName(string propertyName, object value,bool _debug = false)
        {
            // Get the type of this class
            Type type = this.GetType();

            // Get the property info based on the propertyName
            PropertyInfo property = type.GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);

            // If the property is found, set its value
            if (property != null)
            {
                property.SetValue(this, Convert.ChangeType(value, property.PropertyType));
                if (!_debug) return;
                Debug.Log($"Value {value} set to property {propertyName}");
                Debug.Log(property.GetValue(this));
            }
            else
            {
                if (!_debug) return;
                Debug.Log($"Property {propertyName} not found.");
            }
        }

        public void Initialize()
        {
            PackageName = Package;
            Expire = EXP;
            KomposisiInd = komposisiInd;
            KomposisiEng = komposisiEng;
            Berat = berat;
            LogoHalal = logoHalal;
            Contact = contact;
            KodeProduksi = kodeProduksi;
            BarCode = barCode;
            QRCodeLogo = QRCode;
            Seal = seal;
            Sedotan = sedotan;
            LogoRecycle = logoRecycle;
            Rasa = rasa;
            RasaGambar = rasaGambar;
            LogoPilihan = logoPilihan;
            Peringatan = peringatan;
            NutritionFact = nutritionFact;

        }
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