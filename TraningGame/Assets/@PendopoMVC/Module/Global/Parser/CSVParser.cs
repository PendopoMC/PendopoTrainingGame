using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Pendopo.TraningGame.Utils.Data;

namespace Pendopo.Core.Parser
{
    public class CSVParser : MonoBehaviour
    {
        private static Dictionary<string, List<string>> QCData = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> QCLevelData = new Dictionary<string, List<string>>();
        private int dataLenght;
        private static CheckType checkType;
        [SerializeField] private bool isTestingOnStart;
        [SerializeField] private SO_CaseColleciton caseColleciton;
        private static CSVParser instance;
        public static CSVParser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<CSVParser>();
                    if (instance == null)
                    {
                        instance = new GameObject("Spawned CSV Parser", typeof(CSVParser)).GetComponent<CSVParser>();
                    }
                }

                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private void Awake()
        {
            if (Instance != this)
            {
                Destroy(this.gameObject);
            }

            //Don't Destroy this instance on load
            DontDestroyOnLoad(this.gameObject);

            //SelectedLanguage = Language.ENG;
            Debug.Log("CSV CAlled");
            GetAllQCCase();
            GetAllQCLevelCase();
        }
        public void GetAllQCCase()
        {
            if (QCData.Count == 0)
            {
                caseColleciton.csv_cases.Clear();
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
                    caseColleciton.csv_cases.Add(_case);

                }
            }
        }  
        
        
        public void GetAllQCLevelCase()
        {
            if (QCLevelData.Count == 0)
            {
                caseColleciton.csv_level.Clear();

                var csvFile = Resources.Load<TextAsset>(path: "QCData_Quest");

                QCLevelData = ParserHelper.ParseCSVToDict(csvFile, out QCLevelData,out dataLenght);

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
                    caseColleciton.csv_level.Add(newLevel as LevelCase);

                }
            }
        }

    }
}