using System;
using System.Collections;
using System.Linq;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //The provided Array lists
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //I chose to make use of the C# LINQ set operations to query the given lists

            //a. Common elements in both lists
            var commonElements = list1.Intersect(list2);
            Console.WriteLine("Common Elements in both lists");
            Console.WriteLine(string.Join(" ", commonElements));

            //b. Elements only in list1
            var list1Elements = list1.Except(list2);
            Console.WriteLine("Elements only in list1");
            Console.WriteLine(string.Join(" ", list1Elements));

            //Elements only in list2
            var list2Elelments = list2.Except(list1);
            Console.WriteLine("Elements only in list2");
            Console.WriteLine(string.Join(" ", list2Elelments));

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();

        }
    }
}