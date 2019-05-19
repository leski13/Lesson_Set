using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyset1 = new EasySet<int>(new int[] { 1,2,3,4,5});
            var easyset2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easyset3 = new EasySet<int>(new int[] { 3, 4, 5});

            Console.WriteLine("Union");
            foreach(var item in easyset1.Union(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Intersection");
            foreach(var item in easyset1.InterSection(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference 1//2");
            foreach (var item in easyset1.Difference(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference 2//1");
            foreach (var item in easyset2.Difference(easyset1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("1 Subset 2");
            Console.Write(easyset1.Subset(easyset2) + "\n");

            Console.WriteLine("2 Subset 1");
            Console.Write(easyset2.Subset(easyset1) + "\n");

            Console.WriteLine("3 Subset 1");
            Console.Write(easyset1.Subset(easyset3) + "\n");

            Console.WriteLine("Symmetric Difference");
            foreach (var item in easyset2.SymmetricDifference(easyset1))
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
