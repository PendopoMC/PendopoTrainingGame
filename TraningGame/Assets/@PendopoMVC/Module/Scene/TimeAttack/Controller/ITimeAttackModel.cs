using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.TimeAttack
{
    public interface ITimeAttackModel : IBaseModel
    {
        public float time { get; }
        public float maxTime { get; }
        public bool isRunning { get; }
        public string timeString { get; }
    }


}