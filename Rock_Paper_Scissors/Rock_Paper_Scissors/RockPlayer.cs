using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class RockPlayer : IPlayer
    {

        public RockPlayer(string name)
        {
            Name = name;
        }

        public RockPlayer()
        {

        }

        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            Console.WriteLine("Patrick Star's House played rock. ");
            return RPS.rock;
        }
    }
}
