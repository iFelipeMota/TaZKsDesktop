using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;
using TaZKsDesktop.Model;

namespace TaZKsDesktop.Controler
{
    internal class FilesController
    {
        public Project GetProjectData(string name)
        {
            string path = "" + name + ".txt";
            Project project = new Project(name);
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    project.AddTask(this.GetCsvAssignment(line));
                }
            }
            return project;
        }

        private Assignment GetCsvAssignment(string csAssignmentData)
        {
            Assignment assignment = new Assignment();
            assignment.Name = csAssignmentData.Split()[0];
            assignment.EstimatedPomodoros = int.Parse(csAssignmentData.Split()[1]);

            return assignment;
        }

        public void CreateProjectFile(Project project)
        {
            string path = "" + project.GetName() + ".txt";
            File.Create(path);
            foreach(Assignment task in project.GetTaskList())
            {
                File.AppendAllText(path, task.Name + ";" + task.EstimatedPomodoros.ToString());
            }
        }
    }
}
