using System;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;
using Pendopo.Core.Parser;

namespace Pendopo.TraningGame.Utils.Data
{
    [System.Serializable]
    public class ObjectData :BaseClassSerializer
    {
        private string Package { get; set; }
        private string EXP { get; set; }
        private string FlavorPackage { get; set; }
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
        private string nutritionFact { get; set; }
        private string peringatan { get; set; }

        public string PackageName;
        public string FlavorPackageTexture;
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

        public override void Initialize()
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
            FlavorPackageTexture = FlavorPackage;
        }
        public bool finalAssesment;

        public override string ToString()
        {
            return $"Package Name : {PackageName}" +
                $"\n Expire Name : {Expire}" +
                $"\n KomposisiInd Name : {KomposisiInd}" +
                $"\n KomposisiEng Name : {KomposisiEng}" +
                $"\n Berat Name : {Berat}" +
                $"\n LogoHalal Name : {LogoHalal}" +
                $"\n Contact Name : {Contact}" +
                $"\n KodeProduksi Name : {KodeProduksi}" +
                $"\n BarCode Name : {BarCode}" +
                $"\n QRCodeLogo Name : {QRCodeLogo}" +
                $"\n Seal Name : {Seal}" +
                $"\n Sedotan Name : {Sedotan}" +
                $"\n LogoRecycle Name : {LogoRecycle}" +
                $"\n Rasa Name : {Rasa}" +
                $"\n RasaGambar Name : {RasaGambar}" +
                $"\n LogoPilihan Name : {LogoPilihan}" +
                $"\n Peringatan Name : {Peringatan}" +
                $"\n NutritionFact Name : {NutritionFact}";
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