using System;

namespace Console_Post_Test_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCount3 = 0, iCount5 = 0, iCount7 = 0;
            int iPosNumber;

            Console.Write("Enter a positive number:");
            iPosNumber = int.Parse(Console.ReadLine());



            if ((iPosNumber % 3) == 0) iCount3 += 1;

            if ((iPosNumber % 5) == 0) iCount5 += 1;

            if ((iPosNumber % 7) == 0) iCount7 += 1;

            Console.Write("Enter a positive number or -1 to stop it:");
            iPosNumber = int.Parse(Console.ReadLine());



            Console.WriteLine("Total numbers entered divisible by 3 were " + iCount3.ToString());
            Console.WriteLine("Total numbers entered divisible by 5 were " + iCount5.ToString());
            Console.WriteLine("Total numbers entered divisible by 7 were " + iCount7.ToString());

        }
    }
}
