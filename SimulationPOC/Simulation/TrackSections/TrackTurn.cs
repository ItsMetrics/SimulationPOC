using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC.Simulation.TrackSections
{
    // Define a turn
    class TrackTurn : TrackSection
    {

        // Defining a turn
        // The distance at which the turn starts.
        // The angle (total) of the turn (e.g. 45* for a 4 turn oval track
        // InnerRadius - distance of the inside of the track
        // OuterRadius - distance of the outside of the track.
        // IsLeftTurn - defines which wall is the inner radius distance.
        public float StartPoint { get; set; }
        public float Angle { get; set; }
        public float InnerRadius { get; set; }
        public float OuterRadius { get; set; }

        public bool IsLeftTurn { get; set; }
        public TrackTurn(float angle, float innerRadius, float outerRadius, float start, bool isLeftTurn)
        {
            StartPoint = start;
            Angle = angle;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            IsLeftTurn = IsLeftTurn;
        }

        public override float GetSectionDistance(int lane, int maxLanes)
        {
            throw new NotImplementedException();
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
