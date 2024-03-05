using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;

namespace Pendopo.TraningGame.Global.CaseDataCollection
{
    public class CaseDataCollectionModel :BaseModel
    {
        public List<ObjectData> csv_cases = new List<ObjectData>();
        public List<LevelCase> csv_level = new List<LevelCase>();
        public LevelCase currentLevel;
        public LevelCase currentCase;
    }

}