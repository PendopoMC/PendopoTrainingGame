using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Global.ProgressionData;

namespace Pendopo.TraningGame.Module.GUIResult
{

    public class GUI_ResultController : ObjectController<GUI_ResultController,GUI_ResultView>
    {
        private ProgressionDataController progressionData;
        private int finalScore;
        private Progress progress;
        public void ShowResult(ShowResult _result)
        {
            progress = progressionData.Model.progress;
            finalScore = (progress.totalApproved * _view.multiplication) - (progress.totalRejected * _view.multiplication);
            //Get from data progression
            _view.UpdateScore(progress.totalProductQC, progress.totalProductQC * _view.multiplication,
                progress.totalApproved, progress.totalApproved * _view.multiplication, progress.totalRejected, progress.totalRejected * _view.multiplication, finalScore);
            Publish<SetScore>(new SetScore { score = finalScore });
        }
    }
}
