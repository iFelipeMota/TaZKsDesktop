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
        public List<PomodoroTask> PomodoroTasks = new List<PomodoroTask>();
        public Pomodoro(Project project) 
        {
            foreach(Assignment assignment in project.GetTaskList())
            {
                CreateSession(assignment);
            }
        }

        private void CreateSession(Assignment task)
        {
            for(int i = 0; i < task.EstimatedPomodoros; i++)
            {
                PomodoroTask pomodoroTask = new PomodoroTask();
                pomodoroTask.TaskName = task.Name;
                pomodoroTask.TimeSeconds = 1500;
                this.PomodoroTasks.Add(pomodoroTask);
                this.CreateBreak();
            }
        }

        private void CreateBreak()
        {
            PomodoroTask pause = new PomodoroTask();

            if(this.CycleEnds())
            {
                pause.TaskName = "Long Break";
                pause.TimeSeconds = 1500;
            }
            else
            {
                pause.TaskName = "Break";
                pause.TimeSeconds = 300;
            }
        }

        private bool CycleEnds()
        {
            double cycleCalculation = (this.PomodoroTasks.Count + 1) % 8;
            
            if(cycleCalculation == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
