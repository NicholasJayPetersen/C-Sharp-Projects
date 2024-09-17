using System;

namespace Console_Pre_Test_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool blnAnotherGuess = true;
            int iGuess, iRandomNumber;
            Random R = new Random();


            iRandomNumber = R.Next(49) + 1; //Random number between 1 and 50
            while (blnAnotherGuess == true)
            {
                iGuess = int.Parse(Console.ReadLine());
                if (iRandomNumber == iGuess)
                {
                    Console.WriteLine("You guessed it!");
                    blnAnotherGuess = false;
                }
                else
                    Console.WriteLine("Your guess is incorrect…try again!");
            }
        }
    }
   
}
