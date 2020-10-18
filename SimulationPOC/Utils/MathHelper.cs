using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC
{
    public static class MathHelper
    {
        public static float Lerp(float a, float b, float t)
        {
            float tt = Math.Clamp(t, 0.0f, 1.0f);
            // TODO - is it faster to early out in the case of t == 0 or t == 1? Probably just use some other math lib.
            return a * (1 - tt) + b * tt;
        }

        public static double Lerp(double a, double b, double t)
        {
            double tt = Math.Clamp(t, 0.0, 1.0);
            // TODO - is it faster to early out in the case of t == 0 or t == 1? Probably just use some other math lib.
            return a * (1 - tt) + b * tt;
        }
    }
}
