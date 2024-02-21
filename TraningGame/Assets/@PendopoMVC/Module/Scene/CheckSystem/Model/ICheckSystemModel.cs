using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public interface ICheckSystemModel : IBaseModel
    {
        public CompareCheck firstCase { get; }
        public CompareCheck secondCase { get; }
        public int currentCheckCount { get; }
    }
}