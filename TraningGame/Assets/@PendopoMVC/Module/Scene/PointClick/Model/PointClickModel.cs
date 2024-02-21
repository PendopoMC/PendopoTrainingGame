using Agate.MVC.Base;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;

namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickModel : BaseModel, IPointClickModel
    {
        public PointClickModel()
        {
        }

        public CheckType checkType { get; private set; }


        public string data { get; private set; }

        public Texture texture { get; private set; }

        public CompareCheck compareCheck { get; private set; }

        public FocusObjectMessage focusObjectMessage { get; set; }

        public CompareCheck compareCheckMessagec { get; private set; }

        
        public void SetData(CheckType _case, string _data, FocusObjectMessage _focusMessage, CompareCheck _compareCheck)
        {
            focusObjectMessage = _focusMessage;
            compareCheckMessagec = _compareCheck;
            checkType = _case;
            data = _data;
            texture = Resources.Load<Texture>($"Texture/{data}");
        }

    }
}