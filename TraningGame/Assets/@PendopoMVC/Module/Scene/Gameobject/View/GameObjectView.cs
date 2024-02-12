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
            expire.text = model.expire;
            mass.text = model.mass;
            ingredient.text = model.ingredients;
            isDamaged = model.damaged;
        }

        protected override void UpdateRenderModel(IGameObjectModel model)
        {
            expire.text = model.expire;
            mass.text = model.mass;
            ingredient.text = model.ingredients;
            isDamaged = model.damaged;
        }

        public void DestroyObject()
        {
            Destroy(gameObject);
        }
    }
}
