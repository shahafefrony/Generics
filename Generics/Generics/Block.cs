﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Block<T> : IBlock<T> where T : class
    {
        public Block()
        {

        }

        public T Process(T input)
        {
            return input;
        }
    }
}
