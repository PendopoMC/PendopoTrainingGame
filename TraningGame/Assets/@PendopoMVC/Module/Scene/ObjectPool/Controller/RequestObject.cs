using Pendopo.TraningGame.Module.Object;

namespace Pendopo.TraningGame.Message
{
    public struct RequestObject
    {
        public string prefabName;
    }
    public struct RequestObjectCallback
    {
        public GameObjectView gameobjectView;
    }

    public struct RequestReturnObject
    {
        public string prefabName;
        public GameObjectView gameobjectView;
    }

    public struct RequestPopulatePool
    {

    }
}