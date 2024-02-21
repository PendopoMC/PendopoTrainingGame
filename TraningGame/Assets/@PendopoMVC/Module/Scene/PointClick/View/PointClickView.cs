using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickView : ObjectView<IPointClickModel>,IPointerClickHandler
    {

        private UnityAction onClicked;
        public CheckType checkType;
        [SerializeField]private SkinnedMeshRenderer mesh;
        
        protected override void InitRenderModel(IPointClickModel model)
        {
        }

        protected override void UpdateRenderModel(IPointClickModel model)
        {
        }

        public void SetCallback(UnityAction _clicked)
        {
            onClicked = _clicked;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            //Do something when clicked
            onClicked?.Invoke();
        }
    }
}