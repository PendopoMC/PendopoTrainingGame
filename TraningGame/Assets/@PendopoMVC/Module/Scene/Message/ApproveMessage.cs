
namespace Pendopo.TraningGame.Message
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;
    public struct ApproveMessage
    {
        public string actionValue;

        public ApproveMessage(string actionValue)
        {
            this.actionValue = actionValue;
        }
    }
}