
using UnityEngine;
namespace Pendopo.TraningGame.Message
{
    public struct RotateMessage
    {
        public Vector3 rotateVector;

        public RotateMessage(Vector3 rotateVector)
        {
            this.rotateVector = rotateVector;
        }
    }  
    
}