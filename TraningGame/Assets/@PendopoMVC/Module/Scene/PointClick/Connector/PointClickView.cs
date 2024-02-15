using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickView : ObjectView<IPointClickModel>
    {

        private UnityAction onClicked;
        public CheckType checkType;
        private bool isSpriteType { get => checkType == CheckType.Bar_Code || checkType == CheckType.QR_Code; }
        [SerializeField][ShowIf("isSpriteType")] internal Image imageCheck;
        [SerializeField] [HideIf("isSpriteType")] internal TextMeshProUGUI textCheck;
        
        protected override void InitRenderModel(IPointClickModel model)
        {
            if (isSpriteType)
            {
                imageCheck.sprite = Resources.Load<Sprite>($"Sprite/{model.data}");
            }
            else
            {
                textCheck.text = model.data;
            }
        }

        protected override void UpdateRenderModel(IPointClickModel model)
        {
            if (isSpriteType)
            {
                imageCheck.sprite = Resources.Load<Sprite>($"Sprite/{model.data}");
            }
            else
            {
                textCheck.text = model.data;
            }
        }

        public void SetCallback(UnityAction _clicked)
        {
            onClicked = _clicked;
        }

        public void CheckObject()
        {
            onClicked?.Invoke();
        }
    }
}