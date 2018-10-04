using System;

namespace session4
{
    public class Charly
    {
        private string _greeting;
        public string Greeting 
            {
                get{ return _greeting; }
                set{ _greeting = value; }

            }
        public void Greet() 
            {
            Console.WriteLine(_greeting);
            }
    }
}