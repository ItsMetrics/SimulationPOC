using System;
using System.Collections.Generic;
using System.Text;

using SimulationPOC.Simulation;
namespace SimulationPOC
{
    class RaceSim
    {
        private List<HorseBase> _currentRacers;
        public void PopulateRacers(List<HorseBase> racers)
        {
            _currentRacers = racers;
        }


        private float floatLerp(float a, float b, float t)
        {
            float tt = Math.Clamp(t, 0.0f, 1.0f);
            // TODO - is it faster to early out in the case of t == 0 or t == 1? Probably just use some other math lib.
            return a * (1 - tt) + b * tt;
        }

        private float  timeStep = .166f;
        private float distance = 800.0f;
        
        
        private int currentPlace = 1;
        private int ticks = 1;
        public void ResetRace()
        {
            currentPlace = 1;
        }

        public void HorseFinished()
        {
            currentPlace += 1;
        }
        public void SimulateRace()
        {



            List<SimulationHorse> horsesToFinish = InitializeRacers();

            while (horsesToFinish.Count > 0)
            {
                List<SimulationHorse> toRemove = new List<SimulationHorse>();
                // Simulate a race givent the racers in currentRacers
                foreach (SimulationHorse sim in horsesToFinish)
                {
                    if(sim.UpdateTick(timeStep, distance))
                    {
                        Console.WriteLine("Horse: {0} finished the race! Finished in place: {1}. Time: {2}", sim.Name, currentPlace, ticks);
                        toRemove.Add(sim);
                        HorseFinished();
                    }
                }

                // TODO - handle ties
                horsesToFinish.RemoveAll(x => toRemove.Contains(x));
                ticks++;
            }
        }

        private List<SimulationHorse> InitializeRacers()
        {
            // Generate Lots
            List<int> lots = new List<int>();
            for(int i = 0; i < _currentRacers.Count; ++i)
            {
                lots.Add(i);
            }

            Random rand = new Random();

            // Population of the Sim Horses.
            List<SimulationHorse> horsesToFinish = new List<SimulationHorse>();
            foreach (HorseBase h in _currentRacers)
            {
                SimulationHorse sim = new SimulationHorse(h);
                sim.DrawLot(lots, rand);
                horsesToFinish.Add(sim);
            }

            // Testing 
            // TODO : Should this be a LINQ expression or a Lambda
            horsesToFinish.Sort((a, b) => a.CurrentLane.CompareTo(b.CurrentLane));
            foreach(SimulationHorse horse in horsesToFinish)
            {
                Console.WriteLine("Horse: {0} is starting in Lane {1}", horse.Name, horse.CurrentLane);
            }
            return horsesToFinish;
        }
    }
}
