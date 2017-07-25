using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
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
            int max = 50000;
            float forwardsResult = myModel.HarmonicForwards(max);
            float backwardsResult = myModel.HarmonicBackwards(max);
            myView.Say("Forwards Harmonic gets " + forwardsResult);
            myView.Say("Backwards Harmonic gets " + backwardsResult);
            myView.Say("The difference is " + (backwardsResult - forwardsResult));
            myView.Wait();
        }
    }
}
