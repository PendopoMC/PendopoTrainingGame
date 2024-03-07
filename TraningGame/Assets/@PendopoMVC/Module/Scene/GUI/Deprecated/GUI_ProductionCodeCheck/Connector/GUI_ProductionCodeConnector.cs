﻿using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;
namespace Pendopo.TraningGame.Module.ProductionCodeCheck
{
    public class GUI_ProductionCodeConnector : BaseConnector
    {
        GUI_ProductionCodeController _control;
        protected override void Connect()
        {
            Subscribe<SetDateMessage>(_control.SetMessage);
            //Subscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SetDateMessage>(_control.SetMessage);
            //Unsubscribe<PointClick_IngredientMessage>(_control.OnOpenGUI);
        }
    }
}