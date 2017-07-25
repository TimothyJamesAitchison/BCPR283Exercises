using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
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
            myView.Say("Please enter your mark");
            int mark = int.Parse(myView.Get());
            myView.Say(myModel.CheckMark(mark));
            myView.Wait();

        }
    }
}
