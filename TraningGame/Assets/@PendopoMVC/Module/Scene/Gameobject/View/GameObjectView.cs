using Agate.MVC.Base;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectView : ObjectView<IGameObjectModel>
    {
        [SerializeField] private TextMeshProUGUI expire;
        [SerializeField] private TextMeshProUGUI mass;
        [SerializeField] private TextMeshProUGUI ingredient;
        [SerializeField] private bool isDamaged;

        protected override void InitRenderModel(IGameObjectModel model)
        {
            throw new System.NotImplementedException();
            
        }

        protected override void UpdateRenderModel(IGameObjectModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
