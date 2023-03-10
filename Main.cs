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
        private int PomodoroTime = 0;
        private string TxtTime = string.Empty;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PomodoroController pomodoro= new PomodoroController();
            this.StartTasks(pomodoro.CreatePomodoro(""));
            this.webBrowser1.DocumentText = "<html>hello <script>alert('hi');</script></html>";
        }

        private void StartTasks(Pomodoro pomodoro)
        {
            foreach(PomodoroTask task in pomodoro.PomodoroTasks)
            {
                this.StartCountDown(task.TimeSeconds);
                while (this.HasTime())
                {
                    this.ChangeTextTime();
                }
            }
        }

        private void StartCountDown(int seconds)
        {
            this.PomodoroTime= seconds;
            Timer CountDown = new Timer();
            CountDown.Interval = 1000;
            CountDown.Start();
        }

        private bool HasTime()
        {
            if(this.PomodoroTime > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.PomodoroTime--;
        }

        private void ChangeTextTime()
        {
            TimeSpan t = TimeSpan.FromSeconds(this.PomodoroTime);
            this.TxtTime = t.ToString(@"hh\:mm\:ss\:fff");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
