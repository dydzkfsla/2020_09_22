using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    class Class2
    {
    //    static int Sum(int end)
    //    {
    //        int temp = 0;
    //        for (int i = 1; i <= end; i++)
    //        {
    //            temp += i;
    //        }
    //        return temp;
    //    }

        static void Sum(int step, int start=1, int end=100)
        {
            int temp = 0;
            for(int i = start; i <= end; i += step)
            {
                temp += i;
            }
            Console.WriteLine(temp);
        }

        static void Main()
        {
            Sum(1,1, 100);
            Sum(1, end : 100);
            Sum(1, 90);
            Sum(1);
        }
    }
}
