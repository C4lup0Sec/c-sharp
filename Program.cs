using System;

namespace repos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Model = "BMW X1";
            auto.Color = "blanco";
            auto.Year = "1997";
            auto.Arrancar();

            AutoSport autoSport = new AutoSport();
            autoSport.Model = "Ferrari";
            autoSport.Color = "rojo";
            autoSport.Year = "2018";
            autoSport.Arrancar();

            AutoClassic autoClassic = new AutoClassic();
            autoClassic.Model="oldsmobile";
            autoClassic.Color = "arena";
            autoClassic.Year = "1798";
            autoClassic.Arrancar();

            Auto[] autos = new Auto[3];
            autos[0] = auto;
            autos[1] = autoSport;
            autos[2] = autoClassic;

            foreach (Auto a in autos)
            {
                a.Arrancar();
            }
            
            
        }

    }

}