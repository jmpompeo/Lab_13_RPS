using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public interface IPlayer
    {

        public string Name { get; set; }

        public RPS GenerateRPS();
    }
}
