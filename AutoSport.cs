using System;
using System.Collections.Generic;
using System.Text;

namespace repos
{
    public class AutoSport : Auto
    {
        public string PowerGears { get; set; }
        public override void Arrancar()
        {
            Console.WriteLine("RUUUUUN RUUUUUN");
        }
    }
}
