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
        public override void SetView(PointClickView view)
        {
            base.SetView(view);
            _model.SetCase(view.checkType);
            _view.SetCallback(delegate { OnClickCheck(); });
        }

        /// <summary>
        /// Callback for click on view
        /// </summary>
        private void OnClickCheck()
        {
            checkType = Model.checkType;
            switch (checkType)
            {
                case CheckType.Expire:
                    Publish<PointClick_EXPMessage>(Model.pointClick_EXPMessage);
                    break;
                case CheckType.Mass:
                    Publish<PointClick_MassMessage>(Model.pointClick_MassMessage);
                    break;
                case CheckType.Ingredient:
                    Publish<PointClick_IngredientMessage>(Model.pointClick_IngredientMessage);
                    break;
                case CheckType.Color:
                    Publish<PointClick_ColorMessage>(Model.pointClick_ColorMessage);
                    break;
                case CheckType.Production_Code:
                    Publish<PointClick_ProductionCodeMessage>(Model.pointClick_ProductionCodeMessage);
                    break;
                case CheckType.Bar_Code:
                    Publish<PointClick_BarCodeMessage>(Model.pointClick_BarCodeMessage);
                    break;
                case CheckType.QR_Code:
                    Publish<PointClick_QRCodeMessage>(Model.pointClick_QRCodeMessage);
                    break;
                case CheckType.Product_Name:
                    Publish<PointClick_ProductNameMessage>(Model.pointClick_ProductNameMessage);
                    break;
                case CheckType.Package:
                    Publish<PointClick_PackageMessage>(Model.pointClick_PackageMessage);
                    break;
                default:
                    break;
            }
        }
    }
}