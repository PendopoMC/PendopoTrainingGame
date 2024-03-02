using Pendopo.Core.Parser;

namespace Pendopo.TraningGame.Utils.Data
{
    [System.Serializable]
    public class CaseData : BaseClassSerializer
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
        private string nutritionFact { get; set; }
        private string peringatan { get; set; }

        public string[] PackageName;
        public string[] Expire;
        public string[] KomposisiInd;
        public string[] KomposisiEng;
        public string[] Berat;
        public string[] LogoHalal;
        public string[] Contact;
        public string[] KodeProduksi;
        public string[] BarCode;
        public string[] QRCodeLogo;
        public string[] Seal;
        public string[] Sedotan;
        public string[] LogoRecycle;
        public string[] Rasa;
        public string[] RasaGambar;
        public string[] LogoPilihan;
        public string[] Peringatan;
        public string[] NutritionFact;
        
        public override void Initialize()
        {
            PackageName = ParserHelper.SplitLineOnCommaSimple(Package);
            Expire = ParserHelper.SplitLineOnCommaSimple(EXP);
            KomposisiInd = ParserHelper.SplitLineOnCommaSimple(komposisiInd);
            KomposisiEng = ParserHelper.SplitLineOnCommaSimple(komposisiEng);
            Berat = ParserHelper.SplitLineOnCommaSimple(berat);
            LogoHalal = ParserHelper.SplitLineOnCommaSimple(logoHalal);
            Contact = ParserHelper.SplitLineOnCommaSimple(contact);
            KodeProduksi = ParserHelper.SplitLineOnCommaSimple(kodeProduksi);
            BarCode = ParserHelper.SplitLineOnCommaSimple(barCode);
            QRCodeLogo = ParserHelper.SplitLineOnCommaSimple(QRCode);
            Seal = ParserHelper.SplitLineOnCommaSimple(seal);
            Sedotan = ParserHelper.SplitLineOnCommaSimple(sedotan);
            LogoRecycle = ParserHelper.SplitLineOnCommaSimple(logoRecycle);
            Rasa = ParserHelper.SplitLineOnCommaSimple(rasa);
            RasaGambar = ParserHelper.SplitLineOnCommaSimple(rasaGambar);
            LogoPilihan = ParserHelper.SplitLineOnCommaSimple(logoPilihan);
            Peringatan = ParserHelper.SplitLineOnCommaSimple(peringatan);
            NutritionFact = ParserHelper.SplitLineOnCommaSimple(nutritionFact);
        }
    }
}