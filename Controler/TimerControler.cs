using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TaZKsDesktop.Model;

namespace TaZKsDesktop.Controler
{
    internal class TimerControler
    {
        public void CreatePomodoro()
        {

        }

        public void CreateCountDown(int Seconds)
        {
            Timer CountDown = new Timer();
            CountDown.Interval= 1000;
            CountDown.Start();

            if(Seconds == 0)
            {
                CountDown.Stop();
            }
            else
            {
                Seconds--;
            }
        }
    }
}
