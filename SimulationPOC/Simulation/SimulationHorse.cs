using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC.Simulation
{
    public class SimulationHorse : HorseBase 
    {
        public SimulationHorse(HorseBase horse) : base(horse)
        {
            Position = 0.0f;
            currentVelocity = 0;
            currentAcceleration = 0;
        }

        public float Position { get; set; }
        public float currentVelocity { get; set; }
        public float currentAcceleration { get; set; }

        // Update Tick
        // Returns true if horse has completed the race
        public bool UpdateTick(float time, float totalDistance)
        {
            // Update this horse based on its position and distance
            float targetVelocity = GetTargetVelocity(totalDistance);

            // TODO Calculate Acceleration targets
            // Are we above or below the target velocity?
            Position += targetVelocity *time;
            return Position >= totalDistance;
        }

        public float GetTargetVelocity(float totalDistance)
        {
            float distancePercent = Position / totalDistance;
            return MathHelper.Lerp(EarlySpeed, LateSpeed, distancePercent);
        }


        // Lets handle 'lanes' in the race
        private int currentLane;
        public int CurrentLane { get { return currentLane; } }

        public void SetLane(int lane)
        {
            currentLane = lane;
        }


        public int DrawLot(List<int> lots, Random rand)
        {
            var index = rand.Next(0, lots.Count);
            var lane = lots[index];
            lots.RemoveAt(index);

            SetLane(lane);
            return lane;
        }
    }
}
