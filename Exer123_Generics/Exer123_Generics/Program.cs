using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer123_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var someList = new GenericList<int>();
            someList.Add(1);
            someList.Add(15);
            someList.Add(7);
            someList.Add(3);
            someList.Add(25);
            someList.Add(10);

            Console.WriteLine("Min element in the list is: {0}", someList.Min());
            Console.WriteLine("Max element in the list is: {0}", someList.Max());


            var fruitsList = new GenericList<string>();
            fruitsList.Add("appple");
            fruitsList.Add("orange");
            fruitsList.Add("plum");
            fruitsList.Add("banana");
            fruitsList.Add("cherry");
            fruitsList.Add("grapefruit");

            Console.WriteLine();

            Console.WriteLine(fruitsList[3]);
            Console.WriteLine();

            Console.WriteLine(fruitsList.ToString());
            Console.WriteLine();

            Console.WriteLine("Index of \"CHERRY\" is {0}", fruitsList.Indexof("cherry"));

            fruitsList.RemoveElement(5);
            Console.WriteLine(fruitsList.ToString());
            Console.WriteLine();

            fruitsList.Insert(2, "lemon");
            Console.WriteLine(fruitsList.ToString());

            Console.WriteLine();
        
           
            fruitsList.Clear();
            Console.WriteLine(fruitsList.ToString());
            Console.WriteLine();
        }
    }
}
