using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public interface IQueueSystemModel : IBaseModel
    {
        public int stepChecked { get; }
    }
}