using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;
namespace Pendopo.TraningGame.Module.PointClick
{
    public interface IPointClickModel : IBaseModel
    {
        public CheckType checkType { get; }
        public PointClick_EXPMessage  pointClick_EXPMessage { get; }
        public PointClick_BarCodeMessage   pointClick_BarCodeMessage { get; }
        public PointClick_ColorMessage   pointClick_ColorMessage { get; }
        public PointClick_IngredientMessage pointClick_IngredientMessage { get; }
        public PointClick_MassMessage  pointClick_MassMessage { get; }
        public PointClick_QRCodeMessage pointClick_QRCodeMessage { get; }
        public PointClick_ProductNameMessage pointClick_ProductNameMessage  { get; }
        public PointClick_ProductionCodeMessage pointClick_ProductionCodeMessage { get; }
        public PointClick_PackageMessage pointClick_PackageMessage { get; }
        
        public Texture texture { get; }
        public string data { get; }
    }
}