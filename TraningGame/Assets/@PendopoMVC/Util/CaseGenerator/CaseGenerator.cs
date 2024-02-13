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
        public PointClickView[] pointClickViews;

        [Button("Generate Case")]
        private void GenerateCase()
        {
            Case _newCase = new Case();
            for (int i = 0; i < pointClickViews.Length; i++)
            {
                switch (pointClickViews[i].checkType)
                {
                    case CheckType.Expire:
                        _newCase.objectData.expire = pointClickViews[i].Data;
                        _newCase.caseData.expire = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Mass:
                        _newCase.objectData.mass = pointClickViews[i].Data;
                        _newCase.caseData.mass = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Ingredient:
                        _newCase.objectData.ingredients = pointClickViews[i].Data;
                        _newCase.caseData.ingredients = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Color:
                        _newCase.objectData.color = pointClickViews[i].Data;
                        _newCase.caseData.color = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Production_Code:
                        _newCase.objectData.productionCode = pointClickViews[i].Data;
                        _newCase.caseData.productionCode = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Bar_Code:
                        _newCase.objectData.barCode = pointClickViews[i].Data;
                        _newCase.caseData.barCode = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.QR_Code:
                        _newCase.objectData.QRCode = pointClickViews[i].Data;
                        _newCase.caseData.QRCode = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Product_Name:
                        _newCase.objectData.productName = pointClickViews[i].Data;
                        _newCase.caseData.productName = pointClickViews[i].DataToCheck;
                        break;
                    case CheckType.Package:
                        _newCase.objectData.prefabObject = pointClickViews[i].Data;
                        _newCase.caseData.prefabObject = pointClickViews[i].DataToCheck;
                        break;
                    default:
                        break;
                }
            }
            generatedCases.Add(_newCase);
        }
    }
}