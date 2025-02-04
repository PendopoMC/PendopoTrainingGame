using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Pendopo.Core.Parser;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Utils.Data
{
    [CreateAssetMenu(fileName = "Cases Collection", menuName = "Case/Collection")]
    public class SO_CaseColleciton : ScriptableObject
    {
        private Dictionary<string, List<string>> QCData = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> QCLevelData = new Dictionary<string, List<string>>();
        public TextAsset[] CSVAssetCase;
        public TextAsset[] CSVAssetQuest;
        public CaseCollection caseCollection;
        public LevelQuestCollection levelQuestCollection;
        int dataLenght;

        [Button]
        private void GetAllQCCase()
        {
            if (QCData.Count == 0)
            {
                caseCollection.casesLevel.Clear();
                for (int i = 0; i < CSVAssetCase.Length; i++)
                {
                    Case _case = new Case();
                    caseCollection.casesLevel.Add(_case);
                    var csvFile = CSVAssetCase[i];

                    QCData = ParserHelper.ParseCSVToDict(csvFile, out QCData, out dataLenght);
                    ObjectData _data = new ObjectData();
                    for (int j = 0; j < dataLenght - 1; j++)
                    {
                        _data = new ObjectData();
                        foreach (var item in QCData)
                        {
                            _data.SetValueByName(item.Key, QCData[item.Key][j]);
                            if (item.Key == "finalAssesment")
                            {
                                _data.finalAssesment = QCData[item.Key][j] == "Approve";
                            }
                        }
                        _data.Initialize();
                        caseCollection.casesLevel[i].cases.Add(_data);

                    }
                }
               
            }
        }

        [Button]
        private void GetAllQCLevelCase()
        {
            if (QCLevelData.Count == 0)
            {
                levelQuestCollection.questLevel.Clear();
                for (int i = 0; i < CSVAssetQuest.Length; i++)
                {
                    Quest quest = new Quest();
                    levelQuestCollection.questLevel.Add(quest);
                    var csvFile = CSVAssetQuest[i];

                    QCLevelData = ParserHelper.ParseCSVToDict(csvFile, out QCLevelData, out dataLenght);

                    for (int j = 0; j < dataLenght - 1; j++)
                    {
                        ParentClassSerialier<CaseData> newLevel = new LevelCase();
                        BaseClassSerializer _data = new CaseData();

                        foreach (var item in QCLevelData)
                        {
                            if (item.Key == "rule" || item.Key == "QC_ID_Start" || item.Key == "QC_ID_End" || item.Key == "Date")
                            {
                                newLevel.SetValueByName(item.Key, QCLevelData[item.Key][j]);
                            }
                            else
                            {
                                _data.SetValueByName(item.Key, QCLevelData[item.Key][j]);
                            }
                        }
                        newLevel.Initialize(_data as CaseData);
                        levelQuestCollection.questLevel[i].quest.Add(newLevel as LevelCase);

                    }
                }

               
            }
        }
    }

    [System.Serializable]
    public class CaseCollection
    {
        public List<Case> casesLevel = new List<Case>();
    }  
    
    [System.Serializable]
    public class Case
    {
        public List<ObjectData> cases = new List<ObjectData>();
    } 
    
    [System.Serializable]
    public class LevelQuestCollection
    {
        public List<Quest> questLevel = new List<Quest>();
    } 
    [System.Serializable]
    public class Quest
    {
        public List<LevelCase> quest = new List<LevelCase>();
    }
}