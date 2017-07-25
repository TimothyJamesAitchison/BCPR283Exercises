using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
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
            myView.Say("Please enter a number to translate");
            try
            {
                int number = int.Parse(myView.Get());
                myView.Say(myModel.PrintWord(number));
                myView.Say(myModel.PrintWord(number, true));
            }catch(FormatException)
            {
                myView.Say("That wasn't a number!");
            }

            myView.Wait();
        }
    }
}
