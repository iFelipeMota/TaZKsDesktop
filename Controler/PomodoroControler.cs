﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaZKsDesktop.Model;

namespace TaZKsDesktop.Controler
{
    internal class PomodoroControler
    {
        public Pomodoro CreatePomodoro(Project project) {
            return new Pomodoro(project);
        }
    }
}
