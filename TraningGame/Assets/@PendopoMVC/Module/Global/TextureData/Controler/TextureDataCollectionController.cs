using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Message;
using Pendopo.Core.Parser;
using Pendopo.Core.Helper;
using Pendopo.TraningGame.Global.ProgressionData;
namespace Pendopo.TraningGame.Global.TextureDataCollection
{

    public class TextureDataCollectionController : DataController<TextureDataCollectionController,TextureDataCollectionModel>
    {
        RequestTextureCallback textureCallback;
        Texture2D clearTexture;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Debug.Log("Load all Texture");
            GetAllTexture();
            textureCallback = new RequestTextureCallback();
            clearTexture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
            clearTexture.SetPixel(0, 0, new Color(0, 0, 0, 0)); // Transparent pixel
            clearTexture.Apply();
        }
        private void GetAllTexture()
        {
           Texture[] _tex = Resources.LoadAll<Texture>($"Texture/165/");
            foreach (var item in _tex)
            {
                if (_model.packageTexture.ContainsKey(item.name)) continue;
                _model.packageTexture.Add(item.name, item);
            }
            _tex = Resources.LoadAll<Texture>($"Texture/115/");
            foreach (var item in _tex)
            {
                if (_model.packageTexture.ContainsKey(item.name)) continue;
                _model.packageTexture.Add(item.name, item);
            }
        } 
        public Texture GetRequestTexture(string _data)
        {
            if (!_model.packageTexture.ContainsKey(_data)) return clearTexture;
            return _model.packageTexture[_data];
        }
    }
}


namespace Pendopo.TraningGame.Message
{
    public struct RequestTexture
    {
        public ObjectData data;
    }

    public struct RequestTextureCallback
    {
        public Texture basePackage;
        public Texture tx_barCode;
        public Texture tx_qrCode;
        public Texture tx_komposisiEng;
        public Texture tx_komposisiInd;
        public Texture tx_logoHalal;
        public Texture tx_logoPilihan;
        public Texture tx_namaRasaDepan;
        public Texture tx_namaRasaBelakang;
        public Texture tx_logoRasaDepan;
        public Texture tx_logoRasaBelakaang;
        public Texture tx_berat;
        public Texture tx_kodeProduksi;
        public Texture tx_logoRecycle;
        public Texture tx_exp;
        public Texture tx_seal;
        public Texture tx_sedotan;
        public Texture tx_contact;
        public Texture tx_nutrisi;
        public Texture tx_peringatan;
    }
}