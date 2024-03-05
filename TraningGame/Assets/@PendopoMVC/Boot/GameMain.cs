using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Global.CaseDataCollection;
namespace Pendopo.TraningGame.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]
            {
            new CaseDataCollectionConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
            new CaseDataCollectionController()
            };
        }

        protected override IEnumerator StartInit()
        {
            return null;
        }

    }
}