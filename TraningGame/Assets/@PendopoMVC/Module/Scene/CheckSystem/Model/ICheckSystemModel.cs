using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public interface ICheckSystemModel : IBaseModel
    {
        public CheckCaseText firstCaseText { get; }
        public CheckCaseText secondCaseText { get; }
        public CheckCaseNonText firstCaseNonText { get; }
        public CheckCaseNonText secondCaseNonText { get; }
        public bool isFirstCaseText { get; }
        public bool isSecondCaseText { get; }
        public int currentCheckCount { get; }
    }
}