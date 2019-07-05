using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer456.MAtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(10, 10);
            Matrix<int> matrix2 = new Matrix<int>(10, 10);
            Console.WriteLine(matrix1.Cols);

            matrix1[0, 0] = 187;
            matrix2[0, 0] = 10;
            Console.WriteLine(matrix1+ matrix2);

            Console.WriteLine(matrix1 - matrix2);
        }
    }
}
