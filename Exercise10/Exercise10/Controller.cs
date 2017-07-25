namespace Exercise10
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
            int min = 1;
            int max = 100;
            myView.Say("The sum is " + myModel.GetSum(min, max));
            myView.Say("The average is " + myModel.GetAverage(min, max));
            myView.Wait();
        }
    }
}
