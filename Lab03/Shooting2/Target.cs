using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting2
{
    internal class Target
    {
        // target template, radii of circles
        public double R1 = 1;
        public double R2 = 2;
        public double R3 = 3;

        // obstacle for a shooter
        public double WindEffect {  get; set; }

        public Target()
        {
            WindEffect = 0;
        }

        public void ApplyWind(double windX)
        {
            WindEffect = windX;
            Console.WriteLine("DEBUG set obstacle");
        }

        public int RegisterHit(Weapon weapon)
        {
            double adjustedX = weapon.X + WindEffect;
            double defaultY = weapon.Y;

            double distance = Math.Sqrt(adjustedX * adjustedX + defaultY * defaultY);

            Console.WriteLine($"RELEASE Hit at ({adjustedX:F2}, {defaultY:F2}).");
            Console.WriteLine($"DEBUG distance {distance:F2}");

            int score = CheckHitArea(distance);
            Console.WriteLine("DEBUG hit");

            CheckHatchedArea(adjustedX, defaultY);

            return score;
        }

        private int CheckHitArea(double distance)
        {
            if (distance <= R1) return 10;
            else if (distance <= R2) return 5;
            else if (distance <= R3) return 1;
            else return 0;
        }

        private void CheckHatchedArea(double x, double y)
        {
            if (x >= -3 && x <= 3 && y >= 0 && y <= 3) Console.WriteLine("RELEASE IN");
            else if (x == -3 || x == 3 || y == 0 || y == 3) Console.WriteLine("RELEASE AT");
            else Console.WriteLine("RELEASE OUT");
        }
    }
}
