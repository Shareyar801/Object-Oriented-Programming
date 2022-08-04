using System;
using System.Collections;         //System.Collections library will be used for array list
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arlist1 = new ArrayList();
            arlist1.Add("Shareyar");
            arlist1.Add("Farooqui");
            arlist1.Add("19");

            Console.Write("Array through for each loop: ");
            foreach (var item in arlist1)
                Console.Write(item + " ");

            Console.Write("\nArray through for loop: ");
            for (int i = 0; i < arlist1.Count; i++)
                Console.Write(arlist1[i] + " "); 

            Console.WriteLine();
        }
    }
}

/*
output:
Array through for each loop: Shareyar Farooqui 19
Array through for loop: Shareyar Farooqui 19
*/
