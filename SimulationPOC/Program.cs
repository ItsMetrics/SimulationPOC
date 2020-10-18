using System;
using System.Collections.Generic;
namespace SimulationPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulationPOC.Data.NameGenerator namegen = new Data.NameGenerator();
            Console.WriteLine("Generating names:");
            for(int i = 0; i < 40; ++i)
            {
                Console.WriteLine(namegen.GenerateName());
            }


            Console.WriteLine("Off to the Races!");
            List<HorseBase> horses = new List<HorseBase>();

            HorseBase horse1 = new HorseBase();
            horse1.Name = "Early Riser";
            horse1.EarlySpeed = 5.1f;
            horse1.LateSpeed = 3.2f;
            horses.Add(horse1);

            HorseBase horse2 = new HorseBase();
            horse2.Name = "Late To Bed";
            horse2.EarlySpeed = 3.5f;
            horse2.LateSpeed = 4.9f;
            horses.Add(horse2);

            HorseBase median = new HorseBase();
            median.Name = "AVERAGE AMERICAN";
            median.EarlySpeed = 3.8f;
            median.LateSpeed = 4.2f;
            horses.Add(median);

            HorseBase contender = new HorseBase();
            contender.Name = "Challenger";
            contender.EarlySpeed = 3.5f;
            contender.LateSpeed = 4.1f;
            horses.Add(contender);

            HorseBase hare = new HorseBase();
            hare.Name = "The Hare";
            hare.EarlySpeed = 7.0f;
            hare.LateSpeed = 1.0f;
            horses.Add(hare);

            HorseBase lazor = new HorseBase();
            lazor.Name = "CHARGING MY LAZOR";
            lazor.EarlySpeed = 0.1f;
            lazor.LateSpeed = 23;
            horses.Add(lazor);


            HorseBase sisyphus = new HorseBase();
            sisyphus.Name = "Sisyphus";
            sisyphus.EarlySpeed = 20;
            sisyphus.LateSpeed = 0.01f;
            horses.Add(sisyphus);


            // Create the Sim
            RaceSim sim = new RaceSim();
            sim.PopulateRacers(horses);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            sim.SimulateRace();
            watch.Stop();
            Console.WriteLine($"\n Race Completed! Execution time: {watch.ElapsedMilliseconds} ms");        

        }
    }
}
