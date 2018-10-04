using System;
using System.IO;
using System.Collections.Generic;

namespace lastsession1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> values =new List<double>() {50.0, 37.0, 35.0, 32.0, 27.0};
            List<string> times = new List<string>() {"12pm","5pm","6:44pm","8pm","10pm"};

            string file = "/Users/Carlos/Desktop/example1.csv";
            try {
                using (StreamWriter outputFile=new StreamWriter(file)) {
                    outputFile.WriteLine("hora,temperatura C");
                    for (int i=0; i < values.Count; i++) {
                        outputFile.WriteLine($"{times[i]},{values[i]}");
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("tu cosa no sirve");
            }
        }
    }
}