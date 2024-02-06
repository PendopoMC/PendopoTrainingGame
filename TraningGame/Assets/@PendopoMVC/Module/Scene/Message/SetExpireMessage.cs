
namespace Pendopo.TraningGame.Message
{
    public struct SetExpireMessage
    {
        public string expireMessage { get; private set; }

        public SetExpireMessage(string expireMessage)
        {
            this.expireMessage = expireMessage;
        }
    }
    public struct SetMassMessage
    {
        public string massMessage { get; private set; }

        public SetMassMessage(string massMessage)
        {
            this.massMessage = massMessage;
        }
    }
    public struct SetPackageMessage
    {
        public bool isBroken { get; private set; }

        public SetPackageMessage(bool isBroken)
        {
            this.isBroken = isBroken;
        }
    }

    public struct SetIngredientMessage
    {
        public string ingredientMessage { get; private set; }
        public SetIngredientMessage(string ingredientMessage)
        {
            this.ingredientMessage = ingredientMessage;
        }
    }

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