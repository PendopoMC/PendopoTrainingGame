using Agate.MVC.Base;

namespace Pendopo.TraningGame.Global.ProgressionData
{
    public class ProgressionDataModel :BaseModel, IProgressionDataModel
    {
        public Progress progress { get; set; }

        public void ResetProgress()
        {
            progress.totalApproved = 0;
            progress.totalRejected = 0;
            progress.totalProductQC = 0;
        }
    }

    public interface IProgressionDataModel : IBaseModel
    {
        public Progress progress { get; }
    }

    [System.Serializable]
    public class Progress
    {
        public int totalProductQC;
        public int totalApproved;
        public int totalRejected;
        public int levelId;
    }
}
