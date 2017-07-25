using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    interface IView
    {
        void Say<T>(T message);
        void wait();
        String Get();
    }
}
