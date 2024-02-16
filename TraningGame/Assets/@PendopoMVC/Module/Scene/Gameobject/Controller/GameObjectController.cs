using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Module.PointClick;
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
                        _pcC.init(_pcModel, view.pointClickViews[i],_data.prefabObject );
                        break;
                    case CheckType.Expire:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.expire);
                        break;
                    case CheckType.Mass:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.mass);
                        break;
                    case CheckType.Ingredient:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.ingredients);
                        break;
                    case CheckType.Color:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.color);
                        break;
                    case CheckType.Production_Code:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.productionCode);
                        break;
                    case CheckType.Bar_Code:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.barCode);
                        break;
                    case CheckType.QR_Code:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.QRCode);
                        break;
                    case CheckType.Product_Name:
                        _pcC.init(_pcModel, view.pointClickViews[i], _data.productName);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
