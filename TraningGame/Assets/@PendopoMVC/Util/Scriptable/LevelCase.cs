using Pendopo.Core.Parser;

namespace Pendopo.TraningGame.Utils.Data
{
    [System.Serializable]
    public class LevelCase : ParentClassSerialier<CaseData>
    {
        public int ID;
        public int QC_ID_StartValue;
        public int QC_ID_EndValue;
        public string Rule;
        public CaseData SubClass;
        private string id { get; set; }
        private string rule { get; set; }
        private string QC_ID_Start { get; set; }
        private string QC_ID_End { get; set; }


        public override string ToString()
        {
            return $"id : {id}" +
                $"rule : {rule}" +
                $"QC_ID_Start : {QC_ID_Start}" +
                $"QC_ID_Start : {QC_ID_End}";
        }

        public override void Initialize(CaseData _data)
        {
            QC_ID_StartValue = int.Parse(QC_ID_Start);
            QC_ID_EndValue = int.Parse(QC_ID_End);
            Rule = rule;
            SubClass = _data;
            SubClass.Initialize();
        }
         

    }
}