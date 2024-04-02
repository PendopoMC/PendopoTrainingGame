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
        Texture2D clearTexture;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Debug.Log("Load all Texture");
            GetAllTexture();
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