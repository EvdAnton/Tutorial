using System;
using System.Collections.Generic;
using System.Linq;
namespace third_class
{
    class Program
    {
        public static void Main() {

            int[] answer;

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            answer = stringOfPrimeFactors(arr).ToArray();

            answer.OrderBy(i => i);

            answer = answer.Distinct().ToArray();

            string ANSWER = "";

            for (int i = 0; i < answer.Length; i++){

                int tempSum = 0;

                for (int k = 0; k < n; k++) {

                    if (arr[k] % answer[i] == 0) {

                        tempSum += arr[k];      
                    }
                }

                ANSWER += $"({answer[i]} {tempSum}) ";
            }

			Console.WriteLine(ANSWER);
        }

        public static List<int> stringOfPrimeFactors(int[] list)
        {

            int size = list.Length;

            int[] copy = new int[size];

            Array.Copy(list, copy, size);
                     
            List<int> primes = new List<int>();

            for (int i = 0; i < size; i++)
            {   
                for (int k = 2; k <= Math.Abs(copy[i]); k++)
                {
                    while (copy[i] % k == 0) {
                       
                        copy[i] /= k;
                    }
                    if (list[i] % k == 0) {

                    primes.Add(k);
                    }  
                }
            }
            return primes;
        }
      
    }
}

