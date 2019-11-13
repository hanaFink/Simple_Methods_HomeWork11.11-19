using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_lesson8_11._11._19
{
    class Program
    {
        static bool module (int a, int b)// ex.1
        {
            bool is_Module = false;
            if (a % b == 0)
            {
                is_Module = true;
            }
            return is_Module;
        }
        static void someRef (ref int a, ref int b)// ex.2
        {
            a++;
            b *= 2;
        }
        static void someOut (out int a, out int b)//ex.3
        {
            a = 0; b = 0;
            Console.WriteLine("Enter first number");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
             b = Convert.ToInt32(Console.ReadLine());

        }
        static int someParams(params int [] arr)//ex.4
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32( Math.Pow(arr[i], i));
            }
            return sum;
        }
        static int someDefault(int a, int b = 1, int c =-1)//ex.4
        {
         return   a*b*c;

        }
        static void splitArray (int [] arr, out int[] arr1,out int[] arr2  )
        {
             arr1 = new int[arr.Length];
            arr2 = new int[arr.Length];
            int j = 0;
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ( arr[i] >= 0 )
            {
                    arr1[j] =arr[i];
                    j++;
            }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            foreach (var item in arr)
            {
                Console.Write(" "+item  );
            }
            Console.WriteLine();
            foreach (var item in arr1)
            {
                if (item != 0)
                Console.Write("  "+item);
            }
            Console.WriteLine(  );
            foreach (var item in arr2)
            {
                if (item != 0)
                    Console.Write(" "+item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            // Console.WriteLine("Enter first number");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Enter second number");
            //   int num2 = Convert.ToInt32(Console.ReadLine());

            //ex.1
            //  Console.WriteLine((module(num1,num2)== true) ? "no module": "some module");

            //ex.2
            //    someRef(ref num1, ref num2);
            //   Console.WriteLine($" new nums1 {num1}, new num2 {num2}");

            //ex.3
            //    someOut(out int a, out int b);
            //   Console.WriteLine($" new a {a}, new b {b}");

            //ex.4
            // Console.WriteLine(someParams(1,2,3 )); 

            //ex.5
            Console.WriteLine(someDefault(1,5));

            //ex.6
            Console.WriteLine(someDefault(1, c:10));

            //ex.7
            int[] arr_7 = { 2, -1, 5, 7, -2, -100 };
            splitArray(arr_7, out int [] arr1, out int[] arr2);


            


        }
    }
}
