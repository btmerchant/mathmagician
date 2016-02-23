using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        public class Integer
        {
            
            public Integer GetFirst()
            {
                return 0;
            }
            public Integer GetNext()
            {
                return current + 1;
            }
            public int[] GetSequence(int how_many)
            {
                if (how_many > MAX)
                {
                    
                }
                int[] seq_array = new int[how_many];
                int counter = 0;
                seq_array[counter] = GetFirst();
                while (counter < how_many - 1)
                {
                    //seq_array[counter + 1] = GetNext(seq_array[counter]);
                    counter++;
                    seq_array[counter + 1] = GetNext(seq_array[counter - 1]);
                }
                //for (int i = 0, i < how_many,   i++)
                //{
                //    seq_array[i];
                //}
                return seq_array;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
