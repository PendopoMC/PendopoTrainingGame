using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.CheckSystem
{
    public class CheckSystemModel : BaseModel, ICheckSystemModel
    {
        public CheckCaseText firstCaseText { get; private set; }

        public CheckCaseText secondCaseText { get; private set; }

        public CheckCaseNonText firstCaseNonText { get; private set; }

        public CheckCaseNonText secondCaseNonText { get; private set; }

        public bool isFirstCaseText { get; set; }

        public bool isSecondCaseText { get; set; }

        public int currentCheckCount { get; set; }

        public void SetFirstCaseText(CheckCaseText _case)
        {
            isFirstCaseText = true;
            firstCaseText = _case;
        }
        public void SetFirstCaseNonText(CheckCaseNonText _case)
        {
            isFirstCaseText = false;
            firstCaseNonText = _case;
        }
        
        public void SetSecondCaseText(CheckCaseText _case)
        {
            isSecondCaseText = true;
            secondCaseText = _case;
        }
        public void SetSecondCaseNonText(CheckCaseNonText _case)
        {
            isSecondCaseText = false;
            secondCaseNonText = _case;

        }
    }
}