using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
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
            int number;
            myView.Say("Please enter a number to check.");
            number = int.Parse(myView.Get());
            myView.Say(myModel.CheckNumber(number));
            myView.Wait();
        }
    }
}
