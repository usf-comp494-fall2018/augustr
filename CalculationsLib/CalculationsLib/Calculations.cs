using System;

namespace CalculationsLib
{
    public class Calculations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public double Mean(double[] a)
        {
            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            double result = sum / a.Length;

            return result;
        }

        public double Median(double[] a)
        {
            Array.Sort(a);
            int middle = a.Length / 2;
            return a[middle];
        }
    }
}
