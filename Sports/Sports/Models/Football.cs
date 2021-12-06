using System;
using System.Collections.Generic;
using System.Text;

namespace Sports.Models
{
    class Football:BasicRules 
    {
        public string Ball { get; set; }
        public string PlayerNames { get; set; }
        public string Playground { get; set; }

        public void Scoreboard()
        {
            Console.WriteLine("Goal");
        }
    }
}
