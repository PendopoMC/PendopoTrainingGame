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
            for (int i = 0; i < view.pointClickViews.Length; i++)
            {
                PointClickController _pcC = new PointClickController();
                PointClickModel _pcModel = new PointClickModel();
                InjectDependencies(_pcC);
                switch (view.pointClickViews[i].checkType)
                {
                    case CheckType.Package:
                        break;
                    case CheckType.EXP:
                        break;
                    case CheckType.komposisiInd:
                        break;
                    case CheckType.komposisiEng:
                        break;
                    case CheckType.berat:
                        break;
                    case CheckType.logoHalal:
                        break;
                    case CheckType.contact:
                        break;
                    case CheckType.kodeProduksi:
                        break;
                    case CheckType.barCode:
                        break;
                    case CheckType.QRCode:
                        break;
                    case CheckType.seal:
                        break;
                    case CheckType.sedotan:
                        break;
                    case CheckType.logoRecycle:
                        break;
                    case CheckType.rasa:
                        break;
                    case CheckType.rasaGambar:
                        break;
                    case CheckType.logoPilihan:
                        break;
                    case CheckType.peringatan:
                        break;
                    case CheckType.nutritionFact:
                        break;
                }
            }
        }


        public void RotateObject(RotateMessage _message)
        {
            _view.transform.eulerAngles += (_message.rotateVector *Time.deltaTime);
        }

    }
}
