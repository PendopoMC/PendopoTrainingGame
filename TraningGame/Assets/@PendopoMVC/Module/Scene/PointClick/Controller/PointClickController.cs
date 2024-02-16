using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickController : ObjectController<PointClickController, PointClickModel, IPointClickModel, PointClickView>
    {
        private CheckType checkType;
        /// <summary>
        /// Callback for click on view
        /// </summary>
        private void OnClickCheck()
        {
            checkType = Model.checkType;
            switch (checkType)
            {
                case CheckType.Expire:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_EXPMessage>(Model.pointClick_EXPMessage);
                    break;
                case CheckType.Mass:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_MassMessage>(Model.pointClick_MassMessage);
                    break;
                case CheckType.Ingredient:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_IngredientMessage>(Model.pointClick_IngredientMessage);
                    break;
                case CheckType.Color:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_ColorMessage>(Model.pointClick_ColorMessage);
                    break;
                case CheckType.Production_Code:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_ProductionCodeMessage>(Model.pointClick_ProductionCodeMessage);
                    break;
                case CheckType.Bar_Code:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_BarCodeMessage>(Model.pointClick_BarCodeMessage);
                    break;
                case CheckType.QR_Code:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_QRCodeMessage>(Model.pointClick_QRCodeMessage);
                    break;
                case CheckType.Product_Name:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_ProductNameMessage>(Model.pointClick_ProductNameMessage);
                    break;
                case CheckType.Package:
                    UnityEngine.Debug.Log(checkType.ToString());
                    Publish<PointClick_PackageMessage>(Model.pointClick_PackageMessage);
                    break;
                default:
                    break;
            }
        }

        public void init(PointClickModel _model, PointClickView _view,string _data)
        {
            this._model = _model;
            _model.SetData(_data);
            _model.SetCase(_view.checkType);
            _view.SetCallback(delegate { OnClickCheck(); });
            SetView(_view);
        }

    }
}