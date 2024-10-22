using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBewTT01
{
    struct Fraction
    {
        public int m_numerator;
        public int m_denominator;

        //Fraction()                      // конструктор по умолчанию
        //{
        //    m_numerator = 0;
        //    m_denominator = 1;
        //}

        public Fraction(int num, int denom)    //  конструктор с параметрами
        {
            m_numerator = num;
            m_denominator = denom;
        }

        public override string ToString()
        {
           return m_numerator + "/" + m_denominator;
        }
    }
}
