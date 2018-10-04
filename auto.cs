using System;
using System.Collections.Generic;
using System.Text;

namespace repos
{
    public class Auto
    {
        private string model;
        public string Color;
        public string Year { get; set; }

        public string Model
        {
            get  { return model;   }
            set { model = value; }
        }
        public virtual void Arrancar()
        {
            Console.WriteLine("Run Run"); 
        }
    }
}
