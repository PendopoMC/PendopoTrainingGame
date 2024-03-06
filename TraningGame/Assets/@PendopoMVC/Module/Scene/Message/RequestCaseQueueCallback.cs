using System.Collections.Generic;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Message
{
    public struct RequestCaseQueueCallback
    {
        public List<ObjectData> caseCollection;
        public LevelCase caseLevel;
    }

}