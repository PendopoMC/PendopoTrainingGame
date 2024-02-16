using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using Pendopo.TraningGame.Module.PointClick;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Utils.CaseGenerator
{
    public class CaseGenerator : MonoBehaviour
    {
        public List<Case> generatedCases = new List<Case>();

        public bool checkPackage;
        [ShowIf("checkPackage")] [SerializeField] private GameObject prefabPackage;
        [ShowIf("checkPackage")] [SerializeField] private Sprite spriteCheck;

        public bool checkBarCode;
        [ShowIf("checkBarCode")] [SerializeField] private Sprite barCode;
        [ShowIf("checkBarCode")] [SerializeField] private Sprite barCodeCheck;

        public bool checkQRCode;
        [ShowIf("checkQRCode")] [SerializeField] private Sprite qrCode;
        [ShowIf("checkQRCode")] [SerializeField] private Sprite qrCodeCheck;

        public bool checkEXP;
        [ShowIf("checkEXP")] [SerializeField] private string exp;
        [ShowIf("checkEXP")] [SerializeField] private string expToCheck;

        public bool checkMass;
        [ShowIf("checkMass")] [SerializeField] private string mass;
        [ShowIf("checkMass")] [SerializeField] private string massToCheck;

        public bool checkIngredient;
        [ShowIf("checkIngredient")] [SerializeField] private string ingredient;
        [ShowIf("checkIngredient")] [SerializeField] private string ingredientToCheck;

        public bool checkProductionCode;
        [ShowIf("checkProductionCode")] [SerializeField] private string productionCode;
        [ShowIf("checkProductionCode")] [SerializeField] private string productionCodeToCheck;

        public bool checkProductName;
        [ShowIf("checkProductName")] [SerializeField] private string productName;
        [ShowIf("checkProductName")] [SerializeField] private string productNameToCheck;


        [Button("Generate Case")]
        private void GenerateCase()
        {
            Case _newCase = new Case();
            _newCase.objectData = new ObjectData
            {
                barCode = barCode.name,
                color = "",
                expire = exp,
                ingredients = ingredient,
                mass = mass,
                prefabObject = prefabPackage.name,
                productionCode = productionCode,
                productName = productName,
                QRCode = qrCode.name
            };
            _newCase.caseData = new ObjectData
            {
                barCode = barCodeCheck.name,
                color = "",
                expire = expToCheck,
                ingredients = ingredientToCheck,
                mass = massToCheck,
                prefabObject = spriteCheck.name,
                productionCode = productionCodeToCheck,
                productName = productNameToCheck,
                QRCode = qrCodeCheck.name
            };
            
            generatedCases.Add(_newCase);
        }
    }

}