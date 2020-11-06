using System;
using System.Collections.Generic;


namespace third_class
{
    class Program
    {
        public static void Main() {

            List<int> answer = new List<int>();

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            answer = stringOfPrimeFactors(arr);

            answer.Sort();

            clear(ref answer);

            string ANSWER = "";

            for (int i = 0; i < answer.Count; i++){

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

            List<int> primes = new List<int>();

            for (int i = 0; i < size; i++)
            {
                for (int k = 2; k <= abs(list[i]); k++)
                {
                    if (list[i] % k == 0 && isPrime(k))
                    {
                        primes.Add(k);
                    }

                }
            }
            return primes;
        }

        public static bool isPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;

            }
            return true;
        }
        
        public static int abs(int num) {

            if (num < 0)
            {

                return -num;
            }
            else {

                return num;
            }
            
        }

        public static void clear(ref List<int> list)
        {
            int size = list.Count;

            for (int i = 1; i < size; i++) {
                if (list[i] == list[i - 1]) {
                    list.RemoveAt(i);
                    size--;
                    i--;
                }
            }
        }
    }
}

