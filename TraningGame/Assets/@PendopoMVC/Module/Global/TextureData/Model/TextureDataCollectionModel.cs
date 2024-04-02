using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;
namespace Pendopo.TraningGame.Global.TextureDataCollection
{
    public class TextureDataCollectionModel :BaseModel
    {
        public Dictionary<string, Texture> packageTexture = new Dictionary<string, Texture>();
    }
}