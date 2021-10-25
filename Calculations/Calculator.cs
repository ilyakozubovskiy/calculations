using System;

namespace Calculations
{
    public static class Calculator
    {
        public const double PI = 3.1415926535897931;

        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double res = 0;
            for (double i = 1; i <= n; i++)
            {
                res += 1 / i;
            }

            return res;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double res = 0, numerator = 1;
            for (double i = 1; i <= n; i++)
            {
                res += numerator / (i * (i + 1));
                numerator *= -1;
            }

            return res;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double res = 0;
            for (double i = 1; i <= n; i++)
            {
                res += 1 / (i * i * i * i * i);
            }

            return res;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double res = 0;
            for (double i = 1; i <= n; i++)
            {
                res += 1 / (((2 * i) + 1) * ((2 * i) + 1));
            }

            return res;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double res = 1;
            for (double i = 1; i <= n; i++)
            {
                res *= 1 + (1 / (i * i));
            }

            return res;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double res = 0, numerator = -1; 
            for (double i = 1; i <= n; i++)
            {
                res += numerator / ((2 * i) + 1);
                numerator *= -1;
            }

            return res;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double res = 0, denominator = 0, fact = 1, count = 1;
            for (double i = 1; i <= n; i++)
            {   
                denominator += 1 / i;
                res += fact / denominator;
                count++;
                fact *= count;
            }

            return res;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n) 
        {
            double res = Math.Sqrt(2);
            for (int i = 1; i < n; i++)
            {
                res = Math.Sqrt(2 + res);
            }

            return res;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double res = 0, denominator = 0;
            for (double i = 1; i <= n; i++)
            {
                denominator += Math.Sin(PI * i / 180);
                res += 1 / denominator;
            }

            return res;
        }
    }
}
