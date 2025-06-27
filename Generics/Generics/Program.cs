using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataFlow<string> flow = new DataFlow<string>();   
            flow.AddBlock(new UpperCaseBlock());
            flow.AddBlock(new ReverseBlock());
            flow.AddBlock(new ReplaceAWithSixBlock());

            Console.WriteLine(flow.RunFlow("shahaf")); 
        }
    }
}
