using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les7_indexator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(3, 4);

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            Matrix m3 = m1 + m2;
            Console.WriteLine(m3);
        }
    }
}
