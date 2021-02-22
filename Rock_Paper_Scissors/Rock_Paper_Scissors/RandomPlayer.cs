using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class RandomPlayer : IPlayer
    {
        public RandomPlayer(string name)
        {
            Name = name;
        }

        public RandomPlayer()
        {

        }
        
        public string Name { get; set; }

        

        public RPS GenerateRPS()
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);

            if (randomEnum == RPS.paper)
            {
                Console.WriteLine("Weird Al played paper. ");
            }
            else if (randomEnum == RPS.rock)
            {
                Console.WriteLine("Weird Al played rock. ");
            }
            else if (randomEnum == RPS.scissors)
            {
                Console.WriteLine("Weird Al played scissors");
            }

            return randomEnum;
        }


    }
}
