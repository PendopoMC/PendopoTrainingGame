using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public class CheckSystemModel : BaseModel, ICheckSystemModel
    {
        public CompareCheck firstCase { get; private set; }

        public CompareCheck secondCase { get; private set; }
        public CheckType firstCaseType { get; set; }

        public CheckType secondCaseType { get; set; }

        public int currentCheckCount { get; set; }

        public void SetFirstCase(CompareCheck _case)
        {
            firstCaseType = _case.type;
            firstCase = _case;
        }
        public void SetSecondCase(CompareCheck _case)
        {
            secondCaseType = _case.type;
            secondCase = _case;
        }
    }
}