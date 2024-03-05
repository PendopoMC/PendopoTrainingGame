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
        RequestCaseCallback callback = new RequestCaseCallback();
        int dataLenght;
        private Dictionary<string, List<string>> QCData = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> QCLevelData = new Dictionary<string, List<string>>();
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            GetAllQCCase();
            GetAllQCLevelCase();
            Debug.Log("Load all CSV data");
        }
        private void GetAllQCCase()
        {
            if ( QCData.Count == 0)
            {
               _model.csv_cases.Clear();
                var csvFile = Resources.Load<TextAsset>(path: "QCData_Case");

                QCData = ParserHelper.ParseCSVToDict(csvFile, out QCData, out dataLenght);
                ObjectData _data = new ObjectData();
                for (int i = 0; i < dataLenght - 1; i++)
                {
                    _data = new ObjectData();
                    foreach (var item in QCData)
                    {
                        _data.SetValueByName(item.Key, QCData[item.Key][i]);
                        if (item.Key == "finalAssesment")
                        {
                            _data.finalAssesment = QCData[item.Key][i] == "Approve";
                        }
                    }
                    _data.Initialize();
                    _model.csv_cases.Add(_data);

                }
            }
        }


        private void GetAllQCLevelCase()
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

        public void GetCaseQueue(RequestCase _requestLevelCase)
        {
            List<ObjectData> _cases = new List<ObjectData>();

            //Adding all the data
            for (int i = _model.csv_level[_requestLevelCase.levelID].QC_ID_StartValue; i < _model.csv_level[_requestLevelCase.levelID].QC_ID_EndValue; i++)
            {
                _cases.Add(_model.csv_cases[i]);
            }

            Shuffle<ObjectData>(_cases);
            callback.caseCollection = _cases;
            Publish<RequestCaseCallback>(callback);

        }

        void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}