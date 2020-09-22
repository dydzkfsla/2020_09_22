using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    class Class3
    {
        static void ChangeArray(int[] p)
        {
            p[0]++;
        }

        static void ChangeArray1(int[] p)
        {
            p[0]++;
            Console.WriteLine(p[0]);
        }

        static int MyMax(int[] p)
        {
            int temp = p[0];
            for(int i =1; i < p.Length; i++)
            {
                if(temp < p[i])
                    temp = p[i];
            }
            return temp;
        }

        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr1[0]);

            ChangeArray(arr1);
            Console.WriteLine(arr1[0]);

            int[] arr2 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr2[0]);

            ChangeArray1((int[])arr2.Clone());
            Console.WriteLine(arr2[0]);

            Console.WriteLine(arr2.Min());
            Console.WriteLine(arr2.Max());

            Console.WriteLine(MyMax(arr1));

            int[] target = new int[5];
            arr2.CopyTo(target, 0);
            PrintArray(target);
            Array.Copy(arr2, target, 3);
            PrintArray(target);

            int[] arr3 = new int[10] { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 };
            
            PrintArray(arr3);
            Array.Sort((int[])arr3.Clone());
            PrintArray(arr3);
            Array.Reverse(arr3);
            PrintArray(arr3);

            string str = "avdrfnjgalngjk";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str);
            Console.WriteLine(str.Replace("gjk","000000000000000000"));
            Console.WriteLine(str);

            int[,] sarr = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };
            Console.WriteLine(sarr[1,2]);
        }

        private static void PrintArray(int[] target)
        {
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target.GetValue(i) + " ");
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[,] sarr)
        {
            for (int i = 0; i < sarr.GetLength(0); i++)
            {
                for (int k = 0; k < sarr.GetLength(1); k++)
                {
                    Console.Write(sarr[i, k] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
