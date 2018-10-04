using System;
using System.IO;

namespace lastsession
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "/Users/Carlos/Desktop/example.txt";
            try {
                StreamReader reader = File.OpenText(file);
                int i = 1;
                string line= reader.ReadLine();
                while (line !=null){
                    Console.WriteLine("line {0} - {1}",i ,line);
                    line =reader.ReadLine();
                    i++;
                }
                 reader.Close();
            } catch (Exception ex) {
                Console.WriteLine("Error{0}", ex);
            }
        }
    }
}
