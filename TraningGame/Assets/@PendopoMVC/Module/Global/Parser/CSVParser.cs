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
        }
      

    }
}