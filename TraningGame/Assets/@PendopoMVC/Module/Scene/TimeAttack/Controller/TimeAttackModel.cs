using UnityEngine;
using Agate.MVC.Base;
namespace Pendopo.TraningGame.Module.TimeAttack
{
    public class TimeAttackModel : BaseModel, ITimeAttackModel
    {
        public float time { get; private set; }

        public bool isRunning { get; private set; }

        public float maxTime { get; private set; }

        public string timeString { get; private set; }

        public void SetTime(float _time)
        {
            time = 0;
            maxTime = _time;
            isRunning = true;
        }

        public bool IncreaseTime()
        {
            time += Time.deltaTime;
            if(time >= maxTime)
            {
                isRunning = false;
                return false;
            }
            timeString = $"{Mathf.FloorToInt(time / 60).ToString("00")} : {Mathf.FloorToInt(time % 60).ToString("00")}";
            return  true;
        }
        
        public void SetRunning(bool _isRunning)
        {
            isRunning = _isRunning;
        }
    }


}