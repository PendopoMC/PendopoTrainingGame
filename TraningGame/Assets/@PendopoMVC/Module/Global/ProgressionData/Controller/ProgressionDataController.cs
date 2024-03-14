using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Global.ProgressionData
{

    public class ProgressionDataController :DataController<ProgressionDataController,ProgressionDataModel,IProgressionDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.progress = new Progress();
        }
        public void AddProgressApprove(AddProgressionAprrove _message)
        {
            _model.progress.totalProductQC++;
            _model.progress.totalProductQC++;
        }

        public void AddProgressReject(AddProgressionReject _message)
        {
            _model.progress.totalProductQC++;
            _model.progress.totalRejected++;
        }

        public void ResetProgress(ResetProgression _message)
        {
            _model.ResetProgress();
        }

    }

}
