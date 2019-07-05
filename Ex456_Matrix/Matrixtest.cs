using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex456_Matrix
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            Matrix<int> matrixTesting = new Matrix<int>(10, 10);
            Matrix<int> matrixTestingTwo = new Matrix<int>(10, 10);
            Console.WriteLine(matrixTesting.Cols);

            matrixTesting[0, 0] = 200;
            matrixTestingTwo[0, 0] = 3;
            Console.WriteLine(matrixTesting + matrixTestingTwo);

            Console.WriteLine(matrixTesting - matrixTestingTwo);
        }
    }
    
}
