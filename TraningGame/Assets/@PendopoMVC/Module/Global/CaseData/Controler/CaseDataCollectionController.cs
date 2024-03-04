using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.Core.Parser;

namespace Pendopo.TraningGame.Global.CaseDataCollection
{

    public class CaseDataCollectionController : DataController<CaseDataCollectionController,CaseDataCollectionModel>
    {
        int dataLenght;
        private Dictionary<string, List<string>> QCData = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> QCLevelData = new Dictionary<string, List<string>>();
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Debug.Log("Load all CSV data");
            GetAllQCCase();
            GetAllQCLevelCase();
        }
        public void GetAllQCCase()
        {
            if ( QCData.Count == 0)
            {
               _model.csv_cases.Clear();
                var csvFile = Resources.Load<TextAsset>(path: "QCData_Case");

                QCData = ParserHelper.ParseCSVToDict(csvFile, out QCData, out dataLenght);
                ObjectData _case;
                ObjectData _data = new ObjectData();
                for (int i = 0; i < dataLenght - 1; i++)
                {
                    _case = new ObjectData();
                    foreach (var item in QCData)
                    {
                        _data.SetValueByName(item.Key, QCData[item.Key][i]);
                        if (item.Key == "finalAssesment")
                        {
                            _case.finalAssesment = QCData[item.Key][i] == "Approve";
                        }
                    }
                    _data.Initialize();
                    _model.csv_cases.Add(_case);

                }
            }
        }


        public void GetAllQCLevelCase()
        {
            if (QCLevelData.Count == 0)
            {
                _model.csv_level.Clear();

                var csvFile = Resources.Load<TextAsset>(path: "QCData_Quest");

                QCLevelData = ParserHelper.ParseCSVToDict(csvFile, out QCLevelData, out dataLenght);

                Debug.Log($"{dataLenght}");
                for (int i = 0; i < dataLenght - 1; i++)
                {
                    ParentClassSerialier<CaseData> newLevel = new LevelCase();
                    BaseClassSerializer _data = new CaseData();

                    foreach (var item in QCLevelData)
                    {
                        if (item.Key == "rule" || item.Key == "QC_ID_Start" || item.Key == "QC_ID_End")
                        {
                            newLevel.SetValueByName(item.Key, QCLevelData[item.Key][i]);
                        }
                        else
                        {
                            _data.SetValueByName(item.Key, QCLevelData[item.Key][i]);
                        }
                    }
                    newLevel.Initialize(_data as CaseData);
                    _model.csv_level.Add(newLevel as LevelCase);

                }
            }
        }
    }

    public class CaseDataCollectionModel :BaseModel
    {
        public List<ObjectData> csv_cases = new List<ObjectData>();
        public List<LevelCase> csv_level = new List<LevelCase>();
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