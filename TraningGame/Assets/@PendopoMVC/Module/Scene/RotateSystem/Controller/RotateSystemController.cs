using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;

namespace Pendopo.TraningGame.Module.Rotate
{

    public class RotateSystemController : ObjectController<RotateSystemController,RotateSystemView>
    {
        RotateMessage rotateMessage;
        public override void SetView(RotateSystemView view)
        {
            base.SetView(view);
            _view.SetCallback(RotateUp, RotateDown, RotateLeft, RotateRight);
            rotateMessage = new RotateMessage();
        }



        private void RotateLeft()
        {
            rotateMessage.rotateVector = Vector3.left;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateRight()
        {
            rotateMessage.rotateVector = Vector3.right;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateUp()
        {
            rotateMessage.rotateVector = Vector3.up;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateDown()
        {
            rotateMessage.rotateVector = Vector3.down;
            Publish<RotateMessage>(rotateMessage);
        }
    }

}