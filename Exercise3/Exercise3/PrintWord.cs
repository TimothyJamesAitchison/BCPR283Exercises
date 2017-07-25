﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class PrintWord
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();
            Model model = new Model();
            Controller control = new Controller(view, model);
            control.Go();
        }
    }
}