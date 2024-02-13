using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickView : ObjectView<IPointClickModel>
    {
        public CheckType checkType;
        [SerializeField] private string data;
        [SerializeField] private string dataToCheck;
        private bool isPackage { get => checkType == CheckType.Package; }
        [ShowIf("isPackage")] [SerializeField] private GameObject prefabPackage;

        private UnityAction onClicked;

        public string Data { get => data; private set => data = value; }
        public string DataToCheck { get => dataToCheck; private set => dataToCheck = value; }

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

        public void CheckObject()
        {
            onClicked?.Invoke();
        }
    }
}