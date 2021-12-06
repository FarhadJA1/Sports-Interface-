using System;
using System.Collections.Generic;
using System.Text;

namespace Sports.Models
{
    interface BasicRules
    {
        public string Ball { get; set; }

        public string PlayerNames { get; set; }

        public string Playground { get; set; }

        void Scoreboard();





    }
}
