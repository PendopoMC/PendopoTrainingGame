using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
namespace Pendopo.TraningGame.Module.ExpireCheck
{
    public interface IButtonPos
    {
        public RectTransform obj { get; }
        public Vector2 onPosition { get; set; }
        public Vector2 offPosition { get; set; }
       

    }
}