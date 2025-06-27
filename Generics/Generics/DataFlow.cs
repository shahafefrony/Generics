using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DataFlow<T> : IDataFlow<T> where T : class
    {
        private LinkedList<IBlock<T>> blocks;

        public DataFlow() 
        { 
            blocks = new LinkedList<IBlock<T>>();
        }

        public T RunFlow(T input)
        {
            T output = input;
            foreach (IBlock<T> block in blocks)
            {
                output = block.Process(output);
            }
            return output;
        }

        public void AddBlock(IBlock<T> block)
        {
            blocks.AddLast(block);
        }
    }
}
