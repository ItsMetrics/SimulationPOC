using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC
{
    public class HorseBase
    {
        public HorseBase(HorseBase horse)
        {
            Name = horse.Name;
            ID = horse.ID;
            EarlySpeed = horse.EarlySpeed;
            LateSpeed = horse.LateSpeed;
        }

        public HorseBase()
        {
            Name = "";
            ID = Guid.NewGuid();
            EarlySpeed = 0;
            LateSpeed = 0;
        }
        public string Name { get; set; }
        public Guid ID { get; set; }
        public float EarlySpeed { get; set; }
        public float LateSpeed { get; set; }
    }
}
