using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Module.PointClick;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using DG.Tweening;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectController : ObjectController<GameObjectController,GameObjectModel,IGameObjectModel,GameObjectView>
    {
        public void Init(GameObjectModel model, GameObjectView view)
        {
            _model = model;
            ObjectData _data = _model.data;
            SetView(view);

            ///For now this code was not used due to all button that attached to object only have one task : Sugest player to open Rule Book
            //for (int i = 0; i < view.pointClickViews.Length; i++)
            //{
            //    PointClickController _pcC = new PointClickController();
            //    PointClickModel _pcModel = new PointClickModel();
            //    InjectDependencies(_pcC);   
            //}
        }


        public void RotateObject(RotateMessage _message)
        {    
            float swipeAngle = Mathf.Atan2(_message.rotateVector.y, _message.rotateVector.x) * Mathf.Rad2Deg;
            float rotationAmount = _message.rotateVector.magnitude * Time.deltaTime;
            Vector3 rotationAxis = Quaternion.Euler(0, 0, swipeAngle) * Vector3.up;
            _view.transform.Rotate(rotationAxis, rotationAmount,Space.World);
        }
        public void ResetRotation(ResetRotateMessage _mesage)
        {
            _view.transform.eulerAngles = Vector3.down * 30f;
        }
        public void SetupReturn()
        {
            _view.gameObject.SetActive(false);
            _view.transform.eulerAngles = Vector3.down * 30f;
        }
    }
}
