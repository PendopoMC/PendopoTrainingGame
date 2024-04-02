using Agate.MVC.Base;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Module.PointClick;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectView : ObjectView<IGameObjectModel>
    {
        public ObjectData data;
        public Rigidbody rb;
        public Renderer basePackage;
        public Renderer mr_barCode;
        public Renderer mr_qrCode;
        public Renderer mr_komposisiEng;
        public Renderer mr_komposisiInd;
        public Renderer mr_logoHalal;
        public Renderer mr_logoPilihan;
        public Renderer mr_namaRasaDepan;
        public Renderer mr_namaRasaBelakang;
        public Renderer mr_logoRasaDepan;
        public Renderer mr_logoRasaBelakaang;
        public Renderer mr_berat;
        public Renderer mr_kodeProduksi;
        public Renderer mr_logoRecycle;
        public Renderer mr_exp;
        public Renderer mr_seal;
        public Renderer mr_sedotan;
        public Renderer mr_contact;
        public Renderer mr_nutrisi;
        public Renderer mr_peringatan;
        protected override void InitRenderModel(IGameObjectModel model)
        {
           
        }

        protected override void UpdateRenderModel(IGameObjectModel model)
        { 
        }

        public void DestroyObject()
        {
            Destroy(gameObject);
        }

    }
}
