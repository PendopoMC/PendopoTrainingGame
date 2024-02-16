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
    public class CheckSystemController :ObjectController<CheckSystemController,CheckSystemModel,ICheckSystemModel,CheckSystemView>
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

    public class CheckSystemConnector : BaseConnector
    {
        CheckSystemController checkSystemController;
        protected override void Connect()
        {
            Subscribe<CheckCaseText>(checkSystemController.OnCaseTextCheck);
            Subscribe<CheckCaseNonText>(checkSystemController.OnCaseNonTextCheck);
        }

        protected override void Disconnect()
        {
            Unsubscribe<CheckCaseText>(checkSystemController.OnCaseTextCheck);
            Unsubscribe<CheckCaseNonText>(checkSystemController.OnCaseNonTextCheck);
        }
    }

    public class CheckSystemModel : BaseModel, ICheckSystemModel
    {
        public CheckCaseText firstCaseText { get; private set; }

        public CheckCaseText secondCaseText { get; private set; }

        public CheckCaseNonText firstCaseNonText { get; private set; }

        public CheckCaseNonText secondCaseNonText { get; private set; }

        public bool isFirstCaseText { get; set; }

        public bool isSecondCaseText { get; set; }

        public int currentCheckCount { get; set; }

        public void SetFirstCaseText(CheckCaseText _case)
        {
            isFirstCaseText = true;
            firstCaseText = _case;
        }
        public void SetFirstCaseNonText(CheckCaseNonText _case)
        {
            isFirstCaseText = false;
            firstCaseNonText = _case;
        }
        
        public void SetSecondCaseText(CheckCaseText _case)
        {
            isSecondCaseText = true;
            secondCaseText = _case;
        }
        public void SetSecondCaseNonText(CheckCaseNonText _case)
        {
            isSecondCaseText = false;
            secondCaseNonText = _case;
        }
    }

    public interface ICheckSystemModel : IBaseModel
    {
        public CheckCaseText firstCaseText { get; }
        public CheckCaseText secondCaseText { get; }
        public CheckCaseNonText firstCaseNonText { get; }
        public CheckCaseNonText secondCaseNonText { get; }
        public bool isFirstCaseText { get; }
        public bool isSecondCaseText { get; }
        public int currentCheckCount { get; }
    }

    public class CheckSystemView : ObjectView<ICheckSystemModel>
    {
        protected override void InitRenderModel(ICheckSystemModel model)
        {
        }

        protected override void UpdateRenderModel(ICheckSystemModel model)
        {
        }
    }
}