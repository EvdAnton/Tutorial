using System;
using System.Collections.Generic;
using System.Linq;
namespace third_class // never call namespace like this)
// use PascalCase
{
    class Program
    {
        public static void Main()
        {

            // So u can divide your program into 3 parts
            // Initializing
            // Get Prime Factors
            // Get Sum
            // ok and output

            // i think it's will be better if u put all this parts in separate private methods

            int[] answer; // and why is it here? if u use it on 21 line only

            var n = int.Parse(Console.ReadLine()); // naming problem, use var

            var arr = new int[n]; // arr is not display sense of variable, use var

            for (var i = 0; i < n; i++) // use var
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            answer = stringOfPrimeFactors(arr).ToArray(); // maid be it's easier to use List instead of array?  

            answer.OrderBy(i => i); // Order return result, but u dont use it

            answer = answer.Distinct().ToArray(); // u twice use method ToArray(), it is necessary ?

            string ANSWER = ""; // use camelCase for variable and fields

            // u can use Linq to find Sum of elements -> 

            // answer.Select(key => arr.Where(element => element % key == 0).Sum());

            for (int i = 0; i < answer.Length; i++)
            { // foreach is better here

                int tempSum = 0;

                for (int k = 0; k < n; k++)
                { // foreach is better to (foreach (var element in arr))

                    if (arr[k] % answer[i] == 0)
                    {

                        tempSum += arr[k];
                    }
                }

                ANSWER += $"({answer[i]} {tempSum}) "; // in this case u create new string every time, when u rewrite it
                // instead it use StringBuilder class 
            }

            Console.WriteLine(ANSWER);
        }

        public static List<int> stringOfPrimeFactors(int[] list /* why array is list?)*/)
        // why u use public if it's only part of functionality
        // please, always use Pascalcase for method
        {

            var size = list.Length; // use var

            var copy = new int[size]; // if is like helper variable for using, often in programs is named like 'temp' or 'tempSequence'

            Array.Copy(list, copy, size); // u can use list.CopyTo(copy, 0);

            List<int> primes = new List<int>(); // use var

            for (int i = 0; i < size; i++) // u can use foreach here
            {
                for (int k = 2; k <= Math.Abs(copy[i]); k++) // we can change Math.Abs(copy[i]) on Math.Sqrt(Math.Abs(copy[i]))
                {
                    while (copy[i] % k == 0)
                    { // so u can use something like this here -->           if(copy[i] % k == 0)
                      // in this case we don't touch old array at all        {
                        copy[i] /= k;          //                                                         do                               
                    }                          //                                                         { 
                    if (list[i] % k == 0)
                    {    //                                                             copy[i] /= k;
                         //                                                         }while(copy[i] % k == 0)                                                                
                        primes.Add(k);         //                                                         
                    }                          //                                                         primes.Add(k);   
                }                              //                                                     }                 
            }
            return primes;
        }

    }
}