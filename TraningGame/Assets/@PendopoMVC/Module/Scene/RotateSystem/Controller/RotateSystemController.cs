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
        Camera cam;
        Vector3 initialMousePos, currentPos;
        Vector2 deltaInputPos;
        public override void SetView(RotateSystemView view)
        {
            base.SetView(view);
            rotateMessage = new RotateMessage();
            cam = Camera.main;
            _view.SetCallback(InputRotation,ResetRotate);
        }


        private void InputRotation()
        {
            if(Input.GetMouseButtonDown(0))
            {
                initialMousePos = Input.mousePosition;
            }
            else if(Input.GetMouseButton(0))
            {

                currentPos = Input.mousePosition;
                deltaInputPos = initialMousePos- currentPos;
                rotateMessage.rotateVector = deltaInputPos * _view.speedRotation;
                Publish<RotateMessage>(rotateMessage);
            }
        }

        private void RotateLeft()
        {
            rotateMessage.rotateVector = Vector3.down * _view.speedRotation;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateRight()
        {
            rotateMessage.rotateVector = Vector3.up * _view.speedRotation;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateUp()
        {
            rotateMessage.rotateVector = Vector3.right * _view.speedRotation;
            Publish<RotateMessage>(rotateMessage);
        }

        private void RotateDown()
        {
            rotateMessage.rotateVector = Vector3.left * _view.speedRotation;
            Publish<RotateMessage>(rotateMessage);
        }  
        
        private void ResetRotate()
        {
            Publish<ResetRotateMessage>(new ResetRotateMessage());
        }
    }

}