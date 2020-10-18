using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC.Simulation.TrackSections
{
    class TrackStraight : TrackSection
    {
        public override float GetSectionDistance(int lane, int maxLanes)
        {
            return Distance; // straights have the same distance to each end regardless of lane.
        }

        public override void Update(float deltaTime)
        {
            throw new NotImplementedException();
        }

        public override void OnHorseEnter(SimulationHorse horse, float distanceRemaining)
        {
            throw new NotImplementedException();
        }
    }
}
