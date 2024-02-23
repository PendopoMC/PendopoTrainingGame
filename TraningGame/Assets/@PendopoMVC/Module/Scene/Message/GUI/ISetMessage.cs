namespace Pendopo.TraningGame.Message
{
    public interface ISetMessage
    {
        public string data { get; }
    }   
    
    public interface ISetActiveMessage
    {
        public bool active { get; }
    }
}