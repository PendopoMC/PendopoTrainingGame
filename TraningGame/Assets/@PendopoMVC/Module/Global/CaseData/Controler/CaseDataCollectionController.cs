using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Global.CaseData
{

    public class CaseDataCollectionController : DataController<CaseDataCollectionController,CaseDataCollectionModel>
    {

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Debug.Log("Load all CSV data");
        }
    }

    public class CaseDataCollectionModel :BaseModel
    {
    }

    public class CaseDataCollectionConnector : BaseConnector
    {
        protected override void Connect()
        {
            throw new System.NotImplementedException();
        }

        protected override void Disconnect()
        {
            throw new System.NotImplementedException();
        }
    }

}