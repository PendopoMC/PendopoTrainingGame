
namespace Pendopo.TraningGame.Message
{
    public struct SpawnObjectMessage
    {
        public string prefabObject;
        public string expire;
        public string ingredients;
        public string mass;
        public bool damaged;

        public SpawnObjectMessage(string prefabObject, string expire, string ingredients, string mass, bool damaged)
        {
            this.prefabObject = prefabObject;
            this.expire = expire;
            this.ingredients = ingredients;
            this.mass = mass;
            this.damaged = damaged;
        }
    }
}