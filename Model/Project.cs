using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaZKsDesktop.Model
{
    internal class Project
    {
        private String Name;
        private List<Assignment> Tasks = new List<Assignment>();

        public Project(string name, List<Assignment> tasks)
        {
            this.Name = name;
            this.Tasks = tasks;
        }

        public Project(String name)
        {
            this.Name = name;
        }

        public void AddTask(Assignment task)
        {
            this.Tasks.Add(task);
        }

        public List<Assignment> GetTaskList()
        {
            return this.Tasks;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
