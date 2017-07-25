using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CheckMark
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
