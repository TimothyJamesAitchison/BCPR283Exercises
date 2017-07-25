using System;

namespace Exercise10
{
    interface IView
    {
        void Say<T>(T message);
        void Wait();
        String Get();
    }
}
