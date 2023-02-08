using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW080223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector<int> A = new Vector<int> (1, 2, 3);
            Vector<int> B = new Vector<int>(3, 2, 1);
            Vector<int> C = A + B;
            C += 1;
            C *= A;

            Console.WriteLine(
                $"\n\tC = {{{C}}}" +
                $"\n\tLength(C) = {C.Length()}");

            Vector<char> D = new Vector<char>('a', 'b', 'c');
            Vector<char> E = new Vector<char>('A', 'B', 'C');
            Console.WriteLine("\n\tC:");
            Console.Write('\t');
            D.Output();
            Console.WriteLine();
            D.Input();
            if (D == E) Console.WriteLine($"\t{{ {D} }} == {{ {E} }}");
            else Console.WriteLine($"\t{{ {D} }} != {{ {E} }}");

            Console.ReadKey();
        }
    }
}
