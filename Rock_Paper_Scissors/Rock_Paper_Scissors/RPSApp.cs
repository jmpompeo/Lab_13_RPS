using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class RPSApp
    {

        public void PlayGame()
        {
            var human = new HumanPlayer();
            var random = new RandomPlayer("Weird Al");
            var rock = new RockPlayer("Patrick Star's House");

            Console.WriteLine("Care to roshambo?");
            var input = Console.ReadLine();

            do
            {
                human.GetName();
                human.GenerateRPS();
                if (GetOpponent() == random.Name)
                {
                    random.GenerateRPS();
                }
                else
                {
                    rock.GenerateRPS();
                }

            } while (Continue());
        }

       

        private static bool Continue()
        {
            Console.WriteLine("Would you like to continue?: ");
            var input = Console.ReadLine();
            return input.Equals("y", StringComparison.OrdinalIgnoreCase) || input.Equals("yes", StringComparison.OrdinalIgnoreCase);

        }


        private string GetOpponent()
        {
            var randomP = new RandomPlayer("Weird Al");
            var rockP = new RockPlayer("Patrick Star's House");
            string choice;

            do
            {
                Console.Write($"Please choose an opponent: {randomP.Name} or {rockP.Name}: ");
                choice = Console.ReadLine();

                if (choice == randomP.Name)
                {
                   
                    return choice;
                }
                else if (choice == rockP.Name)
                {
                    return choice;
                }
                else
                {
                    ValidateOpponent();
                    return choice;
                }

            } while (!(choice == randomP.Name) || !(choice == rockP.Name)); 
        }

        private void ValidateOpponent()
        {
            var randomP = new RandomPlayer("Weird Al");
            var rockP = new RockPlayer("Patrick Star's House");

            string choice;
            bool isValid = true; 

            do
            {
                Console.WriteLine($"That is not a valid input. Please choose an opponent: {randomP.Name} or {rockP.Name}: ");
                choice = Console.ReadLine();

                if (choice == "Weird Al")
                {
                    break;
                }
                else if (choice == "Patrick Star's House")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"That is not a valid input. Please choose an opponent: {randomP.Name} or {rockP.Name}: ");
                    choice = Console.ReadLine();
                }
                
            } while (isValid);
        }

        private void PrintResult()
        {
            var humanGuess = new HumanPlayer();
            
        }
    }
}


