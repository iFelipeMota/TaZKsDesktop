using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaZKsDesktop.Model;

namespace TaZKsDesktop.Controler
{
    internal class ProjectController
    {
        public Project GetProject(string projectName)
        {
            return this.ReadProjectFile(projectName);
        } 

        private Project ReadProjectFile(string projectName)
        {
            FilesController file = new FilesController();
            return file.GetProjectData(projectName);
        }
    }
}
