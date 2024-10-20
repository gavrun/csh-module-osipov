using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance2
{
    internal struct Distance2
    {
        public int Feet;
        public int Inches;

        //create var faster
        public Distance2(int feet, int inches)
            { this.Feet = feet; this.Inches = inches; }

        //call for requested format
        public override string ToString()
        {
            //return base.ToString(); skipped template
            return this.Feet + "\' - " + this.Inches + "\"";
        }

        public static Distance2 AddDistances(Distance2 distanceA, Distance2 distanceB)
        {
            int totalInches = distanceA.Inches + distanceB.Inches;
            int feet = distanceA.Feet + distanceB.Feet + totalInches / 12;
            int inches = totalInches % 12;

            return new Distance2(feet, inches);
        }
    }
}
