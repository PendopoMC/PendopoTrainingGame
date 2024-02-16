using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickModel : BaseModel, IPointClickModel
    {
        public PointClickModel()
        {
            InitializeStructMessage();
        }

        public CheckType checkType { get; private set; }

        public PointClick_EXPMessage pointClick_EXPMessage { get; private set; }
        public PointClick_BarCodeMessage pointClick_BarCodeMessage { get; private set; }

        public PointClick_ColorMessage pointClick_ColorMessage { get; private set; }

        public PointClick_IngredientMessage pointClick_IngredientMessage { get; private set; }

        public PointClick_MassMessage pointClick_MassMessage { get; private set; }

        public PointClick_QRCodeMessage pointClick_QRCodeMessage { get; private set; }

        public PointClick_ProductNameMessage pointClick_ProductNameMessage { get; private set; }

        public PointClick_ProductionCodeMessage pointClick_ProductionCodeMessage { get; private set; }

        public PointClick_PackageMessage pointClick_PackageMessage { get; private set; }

        public string data { get; private set; }

        public void SetCase(CheckType _case)
        {
            checkType = _case;
        }

        public void SetData(string _data)
        {
            data = _data;
        }

        public void InitializeStructMessage()
        {
            pointClick_BarCodeMessage = new PointClick_BarCodeMessage();
            pointClick_ColorMessage = new PointClick_ColorMessage();
            pointClick_EXPMessage = new PointClick_EXPMessage();
            pointClick_IngredientMessage = new PointClick_IngredientMessage();
            pointClick_MassMessage = new PointClick_MassMessage();
            pointClick_ProductionCodeMessage = new PointClick_ProductionCodeMessage();
            pointClick_ProductNameMessage = new PointClick_ProductNameMessage();
            pointClick_QRCodeMessage = new PointClick_QRCodeMessage();
            pointClick_PackageMessage = new PointClick_PackageMessage();
        }
    }
}