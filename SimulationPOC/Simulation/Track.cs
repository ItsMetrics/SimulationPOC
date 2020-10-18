using System;
using System.Collections.Generic;
using System.Text;
using SimulationPOC.Simulation;
using SimulationPOC.Simulation.TrackSections;
// Defines a track, for use in the simulation
namespace SimulationPOC.Simulation
{
    public class Track
    {        
        public int LaneCount { get; set; }
        
        TrackSection StartSection { get; set; } // Storing track segments as a linked list.
        public float TotalDistance { get; set; }


        private List<SimulationHorse> raceHorses;

        public void InitializeRacers(ref List<SimulationHorse> horses)
        {
            raceHorses = horses;
            // These are the racers for this race.
            // Run whatever algorithm needs to happen for the placements.

            // Place the horses in the starting track position.
            StartSection.AddHorseToSection(horses);
            
        }
    }
}


