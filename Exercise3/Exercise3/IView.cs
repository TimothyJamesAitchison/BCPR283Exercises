﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    interface IView
    {
        void Say<T>(T message);
        String Get();
        void Wait();
    }
}
