using System.Collections.Generic;
using Agate.MVC.Base;
using Pendopo.TraningGame.Utils.Data;
namespace Pendopo.TraningGame.Module.QueueSystem
{
    public class QueueSystemModel : BaseModel, IQueueSystemModel
    {
        public BaseCase currentCase;
        private Queue<BaseCase> casePool = new Queue<BaseCase>();

        public int stepChecked { get; private set; }



        public void AddStep()
        {
            stepChecked++;
        }

        public void Enqueue(BaseCase _item)
        {
            casePool.Enqueue(_item);
            SetDataAsDirty();
        }

        public BaseCase Dequeue()
        {
            return casePool.Dequeue();
        }

    }
}