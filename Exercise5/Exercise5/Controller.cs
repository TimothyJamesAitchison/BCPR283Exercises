using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Controller
    {
        IView myView;
        Model myModel;
        public Controller(IView newView, Model newModel)
        {
            this.myView = newView;
            this.myModel = newModel;
        }

        public void Go()
        {
            int max = 100;
            myView.Say("The sum is: " + myModel.GetSum(max));
            myView.Say("The average is: " + myModel.GetAverage(max));
            myView.Wait();
        }

    }
}
