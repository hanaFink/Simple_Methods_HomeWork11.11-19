using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_work_lesson7_11._11._19
{
    class Program
    {
        private static int IsPrime(int number) // ex.1
        {
            int ifPrime = 1;
            for (int i = 2; i < number/2+1; i++)
            {
                if (number % i == 0)
                {
                    ifPrime = 0;
                    return ifPrime;
                }

            }
            return ifPrime;
            
        }
        private static void CheckArrayForPrimeNumbers(int[] arr)// ex.2
        {
            for (int i = 0; i <arr.Length; i++)
            {
                int cheackIfPrime = IsPrime(arr[i]);
                Console.Write($" {arr[i]} ");
                Console.WriteLine((cheackIfPrime == 0) ? "number is not prime" : "number is prime"); 

            }
        }
        private static void intWhichArrayIsBigger(int[] arr1, int [] arr2)//ex.3
        {
            int sum1 = 0, sum2 = 0;

            foreach (var item in arr1)
            {
                sum1 += item;
            }
            foreach (var item in arr2)
            {
                sum2 += item;
            }
            if (sum1 > sum2)
                Console.WriteLine(" first array  is bigger");
            else if (sum1 < sum2 )
                Console.WriteLine("second array is bigger");
            else
                Console.WriteLine("arrays are even");
        }
        private static int[,] FillRandom()// ex.4
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random p = new Random();
                    arr[i,j] = p.Next(1, 100);
                    Thread.Sleep(20);
                   
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" "+arr[i,j]);

                }
                Console.WriteLine();
            }
            return arr;
        }
        private static void CheckExist(int[,] theMatrix)//ex.4
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 0;
            bool ifExist = false;


            while (i < 10 && ifExist == false)
            {
                while (j < 10 && ifExist == false)
                {
                    if (num == theMatrix[i, j])
                    {
                        Console.WriteLine("exist");
                        ifExist = true;
                    }
                    j++;

                }
                i++;
                j = 0;
            }
            if (ifExist == false)
                Console.WriteLine("missing");
        }
        private  static void sortArray(int?[] arr)
        {
            int? temp = null;
            do
            {
                temp = null;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                       
                    }
                }
            } while (temp != null);

        }
        private static void PrintArray(int?[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" "+arr[i]);
            }
        }
            static void Main(string[] args)
        {
            //ex.1
            /* Console.WriteLine("enter a number");
             int num_1 = Convert.ToInt32(Console.ReadLine());
             int cheackIfPrime = IsPrime(num_1);
             Console.WriteLine((cheackIfPrime == 0) ? "number is not prime" : "number is prime"); */

            //ex.2
            /*int[] primeArr = { 2, 4, 9, 13, 17 };
            CheckArrayForPrimeNumbers(primeArr); */

            //ex.3
            /* int[] arrEx3_0 = { 1,1, 2, 3, 4, 6, 9, 12, 13, 15, 25 };
             int[] arrEx3_1 = { 2,4,6,15,16,27,67 };
             intWhichArrayIsBigger(arrEx3_0, arrEx3_1); */

            //ex.4
            /* int[,] theMatrix = FillRandom();
             for (int i = 1; i < 11; i++)
             {
                 CheckExist(theMatrix);
             } */

            //ex.5
            int?[] arr_5 = { -5, -10, 15, 2, 5, 100 };
            
            sortArray(arr_5);
            PrintArray(arr_5);






        }
    }
}
