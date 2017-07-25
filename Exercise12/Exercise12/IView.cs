using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    interface IView
    {
        void Say<T>(T message);
        void Wait();
        String Get();
    }
}
