using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Core;
using Agate.MVC.Base;

namespace Pendopo.TraningGame.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return null;
        }

        protected override IEnumerator StartInit()
        {
            return null;
        }

    }
}