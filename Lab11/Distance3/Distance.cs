using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance3
{
    internal class Distance
    {
        public int Feet;
        public double Inches;

        // default to zero
        public Distance()
        {
            Feet = 0;
            Inches = 0.0;
        }

        // take values and reduce to normal form
        public Distance(int feet, double inches)
        {
            Feet = feet;
            Inches = inches;

            Feet = Feet + (int)(Inches / 12);
            Inches %= 12;
        }

        // format
        public override string ToString()
        {
            return $"{Feet}' - {Inches}\"";
        }

        // overload plus minus
        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Feet + distance2.Feet, distance1.Inches + distance2.Inches); // ctor handles normal form, etc.
        }
        public static Distance operator -(Distance distance1, Distance distance2)
        {
            int feet = distance1.Feet - distance2.Feet;
            double inches = distance1.Inches - distance2.Inches;
            return new Distance(feet, inches);
        }

        // overload all equality comparison
        public static bool operator ==(Distance distance1, Distance distance2)
        {
            return distance1.Feet == distance2.Feet && Math.Abs(distance1.Inches - distance2.Inches) < 0.001; // math tolerance for fractional inches

        }
        public static bool operator !=(Distance distance1, Distance distance2)
        {
            return !(distance1 == distance2);
        }
        //public override bool Equals(object obj)
        //public override int GetHashCode()
        public static bool operator >(Distance distance1, Distance distance2)
        {
            return distance1.Feet > distance2.Feet || (distance1.Feet == distance2.Feet && distance1.Inches > distance2.Inches);
        }
        public static bool operator <(Distance distance1, Distance distance2)
        {
            return distance1.Feet < distance2.Feet || (distance1.Feet == distance2.Feet && distance1.Inches < distance2.Inches);
        }
        public static bool operator >=(Distance distance1, Distance distance2)
        {
            return distance1 > distance2 || distance1 == distance2;
        }
        public static bool operator <=(Distance distance1, Distance distance2)
        {
            return distance1 < distance2 || distance1 == distance2;
        }
    }
}
