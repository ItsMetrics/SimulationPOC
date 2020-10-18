using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SimulationPOC.Simulation.TrackSections
{
    abstract class TrackSection
    {
        protected float Distance { get; set; }
        public abstract float GetSectionDistance(int lane, int maxLanes);

        public TrackSection NextSection { get; set; }

        protected List<SimulationHorse> horses;

        public abstract void Update(float deltaTime);

        public bool AddHorseToSection(SimulationHorse horse)
        {
            // Make sure we're not adding duplicates
            if (horses.Contains(horse))
                return false;

            horses.Add(horse);
            return true;
        }

        public bool AddHorseToSection(List<SimulationHorse> horses)
        {
            // TODO - clean this up and make it safe.
            horses.AddRange(horses);
            return true;
        }

        // Handle Horses moving to the next track.
        public abstract void OnHorseEnter(SimulationHorse horse, float distanceRemaining);

        public bool TrackHasHorses()
        {
            return horses.Count > 0;
        }
    }
}

