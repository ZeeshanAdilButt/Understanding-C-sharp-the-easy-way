using System;
using System.Collections.Generic;

namespace DelegateCalculatorExample
{

    //delegate that returns true or false depending upon the passed number and expression
    //delegate bool NumberComparerDelegate(int n); --> no need for this now

    class Program
    {
        static void Main(string[] args)
        {

            var sampleArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Running FilterNumbers");
            IEnumerable<int> result2 = FilterNumbers(sampleArray, n => n <5);

            foreach (int num in result2)
            {
                Console.WriteLine(num);
            }

        }

        private static IEnumerable<int> FilterNumbers(IEnumerable<int> sampleArray, Func<int, bool> numberComparer)
        {
            foreach (int number in sampleArray)
            {
                if (numberComparer(number))
                    yield return number;
            }
        }

    }
}
