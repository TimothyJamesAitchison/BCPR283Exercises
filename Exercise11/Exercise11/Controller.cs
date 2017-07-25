using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Controller
    {
        IView myView;
        Model myModel;

        public Controller(IView newView, Model newModel)
        {
            this.myModel = newModel;
            this.myView = newView;
        }

        public void Go()
        {
            for (int max = 10; max <= 14; max++)
            {
                myView.Say("The product of the numbers up to " + max + " is " + myModel.GetProduct(max));
            }
            myView.Wait();
        }
    }
}
