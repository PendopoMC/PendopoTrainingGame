using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using TMPro;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    /// <summary>
    /// TODO : Simplified check case
    /// </summary>
    public class CheckSystemController :DataController<CheckSystemController,CheckSystemModel>
    {
        public void OnMassCheckMessage(SetMassMessage _message)
        {
        }
        public void OnEXPMessage(SetExpireMessage _expMessage)
        {
        }
        public void OnIngredientMessage(SetIngredientMessage _mseesage)
        {
        }


        public void OnCaseTextCheck(CheckCaseText _data)
        {
            if(_model.currentCheckCount<1)
            {
                _model.isFirstCaseText = true;
                _model.currentCheckCount++;
                _model.SetFirstCaseText(_data);
            }
            else
            {
                _model.isSecondCaseText = true;
                _model.SetSecondCaseText(_data);
                Check();
            }
        }   
        
        public void OnCaseNonTextCheck(CheckCaseNonText _data)
        {
            if (_model.currentCheckCount < 1)
            {
                _model.isFirstCaseText = false;
                _model.currentCheckCount++;
                _model.SetFirstCaseNonText(_data);
            }
            else
            {

                _model.isSecondCaseText = false;
                _model.SetSecondCaseNonText(_data);
                Check();
            }
        }

        private void Check()
        {
            if (_model.isFirstCaseText !=_model.isSecondCaseText)
            {
                Debug.Log("Not Match");
                return;
            }

            if (_model.isFirstCaseText && _model.firstCaseText.textToCheck == _model.secondCaseText.textToCheck)
            {
                Debug.Log("Match");
            }  
            else if (!_model.isFirstCaseText && _model.firstCaseNonText.spriteToCheck == _model.firstCaseNonText.spriteToCheck)
            {
                Debug.Log("Match");
            }
            else
            {
                Debug.Log("Not Match");
            }

            _model.currentCheckCount = 0;
        }
    }
}