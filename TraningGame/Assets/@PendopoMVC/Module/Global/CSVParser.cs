using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.Core
{
    public class CSVParser : MonoBehaviour
    {
        private static List<string> languageList = new List<string>();
        private static Dictionary<int, List<string>> QCData = new Dictionary<int, List<string>>();
        private static Dictionary<string, List<string>> QCLevelData = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> JournalLanguageDict = new Dictionary<string, List<string>>();

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

        public delegate void OnChangeLanguage(int id);
        public static event OnChangeLanguage OnLanguageChange;
        public static void DoChangeLanguage(int id)
        {
            if (OnLanguageChange != null)
            {
                OnLanguageChange(id);
            }
        }

        public static string[] SplitLine(string line)
        {
            return (from System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(input: line,
               pattern: @"(((?<x>(?=[,\r\n]+))|""(?<x>([^""]|"""")+)""|(?<x>[^,\r\n]+)),?)", System.Text.RegularExpressions.RegexOptions.ExplicitCapture)
                    select m.Groups[1].Value).ToArray();
        }

        public static List<string> GetAvailableLanguanges()
        {
            if (languageList.Count == 0)
            {
                var csvFile = Resources.Load<TextAsset>(path: "Localization");
                string[] lines = csvFile.text.Split("\n"[0]);
                languageList = new List<string>(SplitLine(lines[0]));
                languageList.RemoveAt(0);
            }
            return languageList;
        }

     

        public static string Journal_GetTextFromID(string id)
        {
            int languageId = (int)checkType;
            if (JournalLanguageDict.Count == 0)
            {
                var csvFile = Resources.Load<TextAsset>(path: "JournalLocalization");
                string[] lines = csvFile.text.Split("\n"[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = SplitLine(lines[i]);
                    if (row.Length > 1)
                    {
                        List<string> worlds = new List<string>(row);
                        worlds.RemoveAt(0);
                        JournalLanguageDict.Add(row[0], worlds);
                    }
                }
            }

            if (JournalLanguageDict.ContainsKey(id))
            {
                var values = JournalLanguageDict[id];
                return values[languageId];

            }
            return id;
        }
        public void GetAllQCCase()
        {
            if (QCData.Count == 0)
            {
                caseColleciton.csv_cases.Clear();
                var csvFile = Resources.Load<TextAsset>(path: "QCData_Case");
                string[] lines = csvFile.text.Split("\n"[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = SplitLine(lines[i]);
                    if (row.Length > 1)
                    {
                        List<string> worlds = new List<string>(row);
                        worlds.RemoveAt(0);
                        QCData.Add(Int32.Parse(row[0]), worlds);
                    }
                }

                foreach (var item in QCData)
                {
                    Case _newCase = new Case();
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        //Debug.Log($"{item.Key}  {item.Value[i]}");
                        _newCase.SetData(i, item.Value[i]);
                    }
                    caseColleciton.csv_cases.Add(_newCase);
                }

            }
        }  
        
        
        public void GetAllQCLevelCase()
        {
            if (QCLevelData.Count == 0)
            {
                caseColleciton.csv_level.Clear();
                var csvFile = Resources.Load<TextAsset>(path: "QCData_Quest");
                string[] lines = csvFile.text.Split("\n"[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    Debug.Log(lines[i]);
                    string[] row = SplitLine(lines[i]);
                    if (row.Length > 1)
                    {
                        List<string> worlds = new List<string>(row);
                        worlds.RemoveAt(0);
                        QCLevelData.Add(row[0], worlds);
                    }
                }

                foreach (var item in QCLevelData)
                {
                    LevelCase newLevel;
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                       // Debug.Log($"{item.Key}  {item.Value[i]}");

                    }
                    //caseColleciton.csv_level.Add(_newCase);
                }

            }
        }

        public void ChangeLanguage(int index)
        {
            DoChangeLanguage(index);
        }

    }
}