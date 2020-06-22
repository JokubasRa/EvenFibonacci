using System;

namespace EvenFibonacci
{
    class Program
    {
        /// <summary>
        /// Sum for 4 000 000 is 4613732
        /// </summary>
        /// 

        static int evenSum(int limit)
        {
            if (limit < 2) return 0;

            
            long a = 0, b = 2;
            long sum = a + b;

            
            while (b <= limit)
            {

                // By expanding fibonaci series I can get that
                //F_n = 4*F_{n-3} + F_{n-6}
                //Since every third fibonaci sequence number is even
                long c = 4 * b + a;

                if (c > limit)
                {
                    break;
                }
                a = b;
                b = c;
                sum += b;
            }

            return (int)sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(evenSum(4000000));
        }
    }
}
