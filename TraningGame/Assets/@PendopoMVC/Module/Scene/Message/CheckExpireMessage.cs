﻿
namespace Pendopo.TraningGame.Message
{
    public struct CheckExpireMessage 
    {
        private bool active;

        public CheckExpireMessage(bool active)
        {
            this.active = active;
        }
    }
}