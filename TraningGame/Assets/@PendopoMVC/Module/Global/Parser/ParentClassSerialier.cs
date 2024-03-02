namespace Pendopo.Core.Parser
{
    public class ParentClassSerialier<TSubClass> : BaseClassSerializer where TSubClass : BaseClassSerializer
    {
        public virtual void Initialize(TSubClass subClass)
        {
            subClass.Initialize();
        }

        public override void Initialize()
        {
        }
    }
}