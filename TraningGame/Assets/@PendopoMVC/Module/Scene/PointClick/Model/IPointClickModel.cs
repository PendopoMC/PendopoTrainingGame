using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;
namespace Pendopo.TraningGame.Module.PointClick
{
    public interface IPointClickModel : IBaseModel
    {
        public FocusObjectMessage focusObjectMessage { get; }
        public CompareCheck compareCheckMessagec { get; }
        public CheckType checkType { get; }        
        public Texture texture { get; }
        public string data { get; }
    }
}