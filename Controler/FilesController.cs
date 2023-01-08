using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaZKsDesktop.Controler
{
    internal class FilesController
    {
        private string Read(string name)
        {
            string path = "" + name + ".txt";

            if (File.Exists(path))
            {
                 return File.ReadAllText(path);
            }
            else
            {
                return null;
            }
        }

        public void GetProjectData()
        {

        }
    }
}
