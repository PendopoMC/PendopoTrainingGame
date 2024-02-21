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
        public CheckSystemController()
        {
            _model.currentCheckCount = 0;
        }

        public void Compare(CompareCheck _data)
        {
            if(_model.currentCheckCount<1)
            {
                _model.currentCheckCount++;
                _model.SetFirstCase(_data);
            }
            else
            {
                _model.SetSecondCase(_data);
                Check();
            }
        }   
        
        private void Check()
        {
            if (_model.firstCaseType !=_model.secondCaseType)
            {
                Debug.Log("Not Match,No Corelation");
                return;
            }

            if (_model.firstCase.data == _model.secondCase.data)
            {
                Debug.Log("Data Matched");
            }
            else
            {
                Debug.Log("Data doesnt match");
            }

            _model.currentCheckCount = 0;
        }
    }
}