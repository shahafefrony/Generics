using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ReverseBlock : IBlock<string>
    {
        public ReverseBlock()
        {

        }
        public string Process(string input)
        {
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            return reversed;
        }
    }
}

