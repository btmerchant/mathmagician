using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci :Integer
    {
        public Fibonacci()
        {
            First = 1;
        }
        public override int GetNext(int current)
        {
            return base.GetNext(current);
        }
        public int GetNth(int n)
        {
            if (n <= 0) { throw new Exception(); };
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetNth(n-1) + GetNth(n-2);
            }
           
            return 0;
        }
    }
}