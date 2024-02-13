using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.Object
{
    public interface IGameObjectModel : IBaseModel
    {
        public string prefabObject { get; }
        public string expire { get; }
        public string ingredients { get; }
        public string mass { get; }
        public string color { get; }
        public string productName { get; }
        public string productionCode { get; }
        public string barCode { get; }
        public string QRCode { get; }
    }
}
