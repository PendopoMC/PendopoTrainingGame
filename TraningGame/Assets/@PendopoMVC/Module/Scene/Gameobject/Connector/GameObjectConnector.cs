using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using UnityEngine;

namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectConnector : BaseConnector
    {
        internal GameObjectController controller;
        protected override void Connect()
        {
            Subscribe<RotateMessage>(controller.RotateObject); 
        }

        protected override void Disconnect()
        {
            Unsubscribe<RotateMessage>(controller.RotateObject);
        }

    }
}
