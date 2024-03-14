using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using TMPro;

namespace Pendopo.TraningGame.Module.GUIResult
{

    public class GUI_ResultController : ObjectController<GUI_ResultController,GUI_ResultModel,IGUI_ResultModel,GUI_ResultView>
    {
        public void ShowResult()
        {
            
        }
    }
    public class GUI_ResultView : ObjectView<IGUI_ResultModel>
    {
        public TextMeshProUGUI t_allProduct, t_productCount, t_productScore;
        public TextMeshProUGUI t_approve, t_approveCount, t_approveScore;
        public TextMeshProUGUI t_deny, t_denyCount, t_denyScore;
        public TextMeshProUGUI t_totalScore;

        protected override void InitRenderModel(IGUI_ResultModel model)
        {
        }

        protected override void UpdateRenderModel(IGUI_ResultModel model)
        {
        }
    }
    public class GUI_ResultConnector : BaseConnector
    {
        protected override void Connect()
        {
        }

        protected override void Disconnect()
        {
        }
    }
    public class GUI_ResultModel : BaseModel,IGUI_ResultModel
    {
    }
    public interface IGUI_ResultModel: IBaseModel
    {
    }
}