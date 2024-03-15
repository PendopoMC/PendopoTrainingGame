using Agate.MVC.Base;

namespace Pendopo.TraningGame.Global.ProgressionData
{
    public class ProgressionDataModel :BaseModel, IProgressionDataModel
    {
        public Progress progress { get; set; }

        public Score score { get; set; }

        public void ResetProgress()
        {
            progress.totalApproved = 0;
            progress.totalRejected = 0;
            progress.totalProductQC = 0;
        }
        public void SetScore(int _score)
        {
            if (score.highScore > _score) return;
            score.highScore = score.currentScore = _score;
        }
    }

    public interface IProgressionDataModel : IBaseModel
    {
        public Progress progress { get; }
        public Score score { get; }
    }

    [System.Serializable]
    public class Progress
    {
        public int totalProductQC;
        public int totalApproved;
        public int totalRejected;
        public int levelId;
    }

    public class Score
    {
        public int highScore;
        public int currentScore;
    }
}
