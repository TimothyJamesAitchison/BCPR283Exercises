using System;

namespace Exercise10
{
    class ConsoleView : IView
    {
        public string Get()
        {
            return Console.ReadLine();
        }

        public void Say<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Wait()
        {
            Console.ReadKey();
        }
    }
}
