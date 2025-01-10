using System;

namespace Console_Passing_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1, iNum2;
            double dResult=0;
            iNum1 = 10;
            iNum2 = 30;
            ComputeAverage(iNum1, iNum2, ref dResult);
            Console.Write("Average is " + dResult);
            Console.ReadKey();
        }

        private static void ComputeAverage(int X, int Y, ref double Z)
        {
            Z = (X + Y) / 2;
        }
    }
}
