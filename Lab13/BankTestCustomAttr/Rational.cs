using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestCustomAttr
{
    [CustomAttribute.DeveloperInfo("Developer", Date = "11-09-2024"), 
        CustomAttribute.DeveloperInfo("Lead Developer", Date = "11-09-2024")]
    public class Rational
    {
        private int dividend = 0;

        private int divisor = 1;

        // constructors 
        public Rational(int dividend)
        {
            this.dividend = dividend;
            this.divisor = 1;
        }

        public Rational(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentOutOfRangeException("Divisor cannot be zero");
            }
            else
            {
                this.dividend = dividend;
                this.divisor = divisor;
            }
        }

        public Rational(Rational r1)
        {
            this.dividend = r1.dividend;
            this.divisor = r1.divisor;
        }

        // operators
        public static bool operator ==(Rational r1, Rational r2)
        {
            return (r1.dividend * r2.divisor) == (r2.dividend * r1.divisor);
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return (r1.dividend * r2.divisor) < (r2.dividend * r1.divisor);
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return !((r1 < r2) || (r1 == r2));
        }

        public static bool operator <=(Rational r1, Rational r2)
        {
            return !(r1 > r2);
        }

        public static bool operator >=(Rational r1, Rational r2)
        {
            return !(r1 < r2);
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            Rational tempR1 = new Rational(r1);
            Rational tempR2 = new Rational(r2);

            int commonDivisor;
            if (tempR1.divisor != tempR2.divisor)
            {
                commonDivisor = tempR1.divisor * tempR2.divisor;

                tempR1.dividend *= tempR2.divisor;
                tempR2.dividend *= tempR1.divisor;
            }
            else
            {
                commonDivisor = tempR1.divisor;
            }

            Rational result = new Rational(tempR1.dividend + tempR2.dividend, commonDivisor);
            return result;
        }
        public static Rational operator +(Rational r1, int i1)
        {
            Rational r2 = new Rational(i1 * r1.divisor, r1.divisor);

            return r1 + r2;
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational tempR1 = new Rational(r1);
            Rational tempR2 = new Rational(r2);

            int commonDivisor;
            if (tempR1.divisor != tempR2.divisor)
            {
                commonDivisor = tempR1.divisor * tempR2.divisor;

                tempR1.dividend *= tempR2.divisor;
                tempR2.dividend *= tempR1.divisor;
            }
            else
            {
                commonDivisor = tempR1.divisor;
            }

            Rational result = new Rational(tempR1.dividend - tempR2.dividend, commonDivisor);
            return result;
        }

        public static Rational operator -(Rational r1, int i1)
        {
            Rational r2 = new Rational(i1 * r1.divisor, r1.divisor);

            return r1 - r2;
        }

        public static Rational operator ++(Rational r1)
        {
            return r1 + 1;
        }

        public static Rational operator --(Rational r1)
        {
            return r1 - 1;
        }

        public static explicit operator float(Rational r1)
        {
            float temp;
            temp = (float)r1.dividend / r1.divisor;
            return temp;
        }

        public static explicit operator int(Rational r1)
        {
            float temp;
            temp = (float)r1.dividend / r1.divisor;
            return (int)temp;
        }

        public static implicit operator Rational(int i1)
        {
            Rational temp = new Rational(i1, 1);
            return temp;
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            int dividend = r1.dividend * r2.dividend;
            int divisor = r1.divisor * r2.divisor;
            Rational temp = new Rational(dividend, divisor);
            return temp;
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            Rational temp = new Rational(r2.divisor, r2.dividend);
            return r1 * temp;
        }

        public static Rational operator %(Rational r1, int i1)
        {
            int temp = (int)r1;

            Rational diff = r1 - temp;

            int remainder = temp % i1;

            diff = diff + remainder;
            return diff;
        }

        // methods
        public override string ToString()
        {
            return String.Format("{0}/{1}", dividend, divisor);
        }

        public override bool Equals(Object r1)
        {
            return (this == (Rational)r1);
        }
    }
}
