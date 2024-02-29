namespace Pendopo.Core.Parser
{
    public interface IParserValueSerializers<TSubClass> : IParserValueSerializer where TSubClass : IParserValueSerializer
    {
        public void Initialize(TSubClass subClass)
        {
            subClass.Initialize();
        }
    }
}