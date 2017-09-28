using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;
            while (ProgramContinue == true)
            {

                Console.WriteLine("Welcome to the Grand Circus! Roll the Dice? (y/n)");

                string userinput = Console.ReadLine();

                if (userinput == "y")
                {
                    Console.WriteLine("How many sides does your dice have?");

                    int diceface = int.Parse(Console.ReadLine());
                    Console.WriteLine("You selected your dice to have" + diceface + "sides");


                    Console.WriteLine("You Rolled");

                    int Dice1 = rnd(1, diceface);
                    int Dice2 = rnd(1, diceface)-1;

                    Console.WriteLine(Dice1);
                    Console.WriteLine(Dice2);






                }
                else
                {
                    Console.WriteLine("Alright! Bye");

                    ProgramContinue = false;
                }



                String UserChoice;
                Console.WriteLine("Do you want to roll the dice again? (N/No/y/yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No")
                {
                    ProgramContinue = false;
                }

            }


        }

        public static int rnd(int Numb1, int diceface)
        {
            Random R = new Random();

            int result = R.Next(1, diceface + 1);
         

            return result;
            

        }

    
 
 

    }
}
