using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaZKsDesktop.Model
{
    internal class PomodoroTask
    { 
        public string TaskName { get; set; }
        public int TimeSeconds;
    }

        internal class Pomodoro
    {
        List<PomodoroTask> PomodoroTasks = new List<PomodoroTask>();
        public Pomodoro(Project project) 
        {
            foreach(Assignment assignment in project.GetTaskList())
            {

            }
        }

        private void CreateSession(Assignment task)
        {
            for(int i = 0; i < task.EstimatedPomodoros; i++)
            {
                PomodoroTask pomodoroTask = new PomodoroTask();
                pomodoroTask.TaskName = task.Name;
                pomodoroTask.TimeSeconds = 1500;
                this.SetPause();
            }
        }

        private void SetPause()
        {

        }
    }
}
