using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Module.GUIDataCheck;

namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public class GUI_ExpireCheckController : GUI_DataCheckController<GUI_ExpireCheckController,GUI_ExpireCheckView>
    {
        protected override void SetCallBack()
        {
            SetExpireMessage mesage = new SetExpireMessage("Data");
            _view.publishMessage += PublishMessage;
        }
        protected override void PublishMessage()
        {
            CompareCheck checkCaseText = new CompareCheck { data = _view.t_data.text };
            Publish<CompareCheck>(checkCaseText);
        }
    }
}