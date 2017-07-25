namespace Exercise10
{
    class SumAndAverage
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();
            Model model = new Model();
            Controller controller = new Controller(view, model);
            controller.Go();
        }
    }
}
