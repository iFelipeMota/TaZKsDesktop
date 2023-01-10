using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaZKsDesktop.Controler;
using TaZKsDesktop.Model;

namespace TaZKsDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PomodoroControler pomodoro= new PomodoroControler();
            this.StartTasks(pomodoro.CreatePomodoro(""));
        }

        private void StartTasks(Pomodoro pomodoro)
        {
            foreach(PomodoroTask task in pomodoro.PomodoroTasks)
            {
                this.CreateCountDown(task.TimeSeconds);
            }
        }

        private void CreateCountDown(int Seconds)
        {
            Timer CountDown = new Timer();
            CountDown.Interval = 1000;
            CountDown.Start();

            if (Seconds == 0)
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
