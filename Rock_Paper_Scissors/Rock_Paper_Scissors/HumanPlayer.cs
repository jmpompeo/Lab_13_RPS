using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class HumanPlayer : IPlayer
    {

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public HumanPlayer()
        {

        }

        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            bool isInvalid = false;
            
            

            do
            {
                Console.WriteLine("Enter (r)ock, (p)aper, or (s)cissors: ");
                var input = Console.ReadLine();

                if (input == "rock")
                {
                    Console.WriteLine("You played rock. ");
                    return RPS.rock;
                }
                else if (input == "paper")
                {
                    Console.WriteLine("You played paper. ");
                    return RPS.paper;
                }
                else if (input == "scissors")
                {
                    Console.WriteLine("You played scissors. ");
                    return RPS.scissors;
                }
                else
                {
                    ValidateRPS(); 
                    return default;
                }

            } while (!isInvalid);



        }
        public string GetName()
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            return name;
        }

        private void ValidateRPS()
        {
            bool isValid = true;
            string input;

            do
            {
                Console.Write("That is not a valid input. Please enter rock, paper, or scissors: ");
                input = Console.ReadLine();

                if (input.Equals("rock",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (input.Equals("paper", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (input.Equals("scissors", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.Write("That is not a valid choice. Please select rock, paper, or scissors: ");
                    input = Console.ReadLine();
                }

            } while (isValid);
        }

       


    }
}
