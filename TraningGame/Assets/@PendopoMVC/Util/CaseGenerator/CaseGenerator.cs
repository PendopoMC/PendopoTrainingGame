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
        [ShowIf("checkPackage")] [SerializeField] private string prefabPackage;
        [ShowIf("checkPackage")] [SerializeField] private string spriteCheck;

        public bool checkBarCode;
        [ShowIf("checkBarCode")] [SerializeField] private string barCode;
        [ShowIf("checkBarCode")] [SerializeField] private string barCodeCheck;

        public bool checkQRCode;
        [ShowIf("checkQRCode")] [SerializeField] private string qrCode;
        [ShowIf("checkQRCode")] [SerializeField] private string qrCodeCheck;

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
                barCode = barCode,
                color = "",
                expire = exp,
                ingredients = ingredient,
                mass = mass,
                prefabObject = prefabPackage,
                productionCode = productionCode,
                productName = productName,
                QRCode = qrCode
            };
            _newCase.caseData = new ObjectData
            {
                barCode = barCodeCheck,
                color = "",
                expire = expToCheck,
                ingredients = ingredientToCheck,
                mass = massToCheck,
                prefabObject = spriteCheck,
                productionCode = productionCodeToCheck,
                productName = productNameToCheck,
                QRCode = qrCodeCheck
            };
            
            generatedCases.Add(_newCase);
        }
    }

}