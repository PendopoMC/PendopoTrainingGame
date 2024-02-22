using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;

namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickView : ObjectView<IPointClickModel>,IPointerClickHandler
    {

        private UnityAction onClicked;
        public CheckType checkType;
        [SerializeField]private SkinnedMeshRenderer mesh;
        private int matId;
        public int MatID { get => matId; set => matId = value; }
        public SkinnedMeshRenderer Mesh { get => mesh; set => mesh = value; }

        protected override void InitRenderModel(IPointClickModel model)
        {
          //  Mesh.sharedMaterials[MatID].SetTexture("_MainTex", model.texture);
        }

        protected override void UpdateRenderModel(IPointClickModel model)
        {
          //  Mesh.sharedMaterials[MatID].SetTexture("_MainTex", model.texture);
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