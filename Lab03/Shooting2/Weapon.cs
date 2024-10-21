using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting2
{
    internal class Weapon
    {
        // projectile position
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;

        // random number
        private Random random = new Random();

        // clip capacity
        public int NumShots { get; set; }
        public int initialShots { get; set; } // issue with for loop sealing crossbow.NumShots

        public Weapon(int numShots)
        {
            //; empty ctor, at least it was before
            //X = 0; Y = 0;
            NumShots = numShots;
            initialShots = numShots;
        }

        // shot coordinates X and Y
        public void Shoot()
        {
            if (NumShots > 0)
            {
                // random range from -10 to 10
                X = random.NextDouble() * 2 - 1;
                Y = random.NextDouble() * 2 - 1;

                Console.WriteLine($"RELEASE Weapon shot at ({X:F2}, {Y:F2})");

                RemoveProjectile();
            }
            else
            {
                Console.WriteLine("RELEASE Easy, cowboy!");
            }
            

        }
        public void RemoveProjectile()
        {
            if (NumShots > 0)
            {
                //X = 0; Y = 0;
                NumShots--;
                Console.WriteLine("DEBUG projectile removed");
            }
        }
    }
}
