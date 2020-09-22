using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    class Program
    {
        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr(ref int x)
        {
            x = x * x;
        }

        static void GetName(out string name, out int id)
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Id: ");
            id = int.Parse(Console.ReadLine());
        }

        static void PrintIntParams(params int[] arr)
        {
            for(int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int x = 10;
            string name;
            int id;

            Sqr(x);
            Console.WriteLine(x);

            Sqr(ref x);
            Console.WriteLine(x);

            GetName(out name,out id);
            Console.WriteLine($"out: {name} {id}");

            PrintIntParams(1,2,3,4);

            int[] MyIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(MyIntArray);

            PrintIntParams();

        }
    }
}
