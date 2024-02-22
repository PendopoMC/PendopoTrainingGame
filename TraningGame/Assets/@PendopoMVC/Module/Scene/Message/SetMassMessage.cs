﻿
namespace Pendopo.TraningGame.Message
{
    public struct SetMassMessage : ISetMessage
    {
        public SetMassMessage(string data)
        {
            this.data = data;
        }

        public string data { get; private set; }
    }
}