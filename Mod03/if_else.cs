using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int mSales = 12000;

            if1(mSales);
            if2(mSales);
            if3(mSales);
            if4(mSales);
            if5(mSales);
            if6(mSales);
            if7(mSales);
        }

        private static void if1(int mSales) // вложение if
        {
            int mBonus;

            if (mSales >= 10000)
            {
                if (mSales >= 25000)
                {
                    mBonus = 2000;
                }
                else
                {
                    mBonus = 1000;
                }
            }
            else
            {
                mBonus = 0;
            }

            Console.WriteLine(mBonus);
        }

        private static void if2(int mSales) // вложение if, но ненаглядно
        {
            int mBonus;

            if (mSales >= 10000)
            if (mSales >= 25000)
                     mBonus = 2000;
            else
                    mBonus = 1000;
            else
                mBonus = 0;

            Console.WriteLine(mBonus);
        }

        private static void if3(int mSales)   // порядок проверки - от наибольшего к наименьшему
        {
            int mBonus;

            if (mSales >= 25000)
            { 
                mBonus = 2000;
            }
            else if (mSales >= 10000)
            {
                mBonus = 1000;
            }
            else
            {
                mBonus = 0;
            }

            Console.WriteLine(mBonus);
        }

        private static void if4(int mSales)   // порядок проверки - от наибольшего к наименьшему
        {
            int mBonus;

            if (mSales >= 25000)
            {
                mBonus = 2000;
            }
            else if (mSales >= 10000)
            {
                mBonus = 1000;
            }
            else
            {
                mBonus = 0;
            }

            Console.WriteLine(mBonus);
        }

        private static void if5(int mSales)   // порядок проверки - от наименьшего к наибольшему
        {
            int mBonus;

            if (mSales < 10000)
            {
                mBonus = 0;
            }
            else if (mSales < 25000)
            {
                mBonus = 1000;
            }
            else
            {
                mBonus = 2000;
            }

            Console.WriteLine(mBonus);
        }

        private static void if6(int mSales) // допущена ошибка, проверьте mSales=12000
        {
            /*Компонент else относится к ближайшему предшествующему компоненту if, 
             * разрешенному правилами синтаксиса*/
            int mBonus;

            if (mSales >= 10000)
                mBonus = 1000;
            if (mSales >= 25000)
               mBonus = 2000;
       
            else            // при mSales меньше 12000, бонус 0!!!
                mBonus = 0;

            Console.WriteLine(mBonus);
        }

        private static void if7(int mSales) // исправлена ошибка, проверьте mSales=12000
        {
            /*Компонент else относится к ближайшему предшествующему компоненту if, 
             * разрешенному правилами синтаксиса*/
            int mBonus;

            if (mSales >= 10000)
            {
                mBonus = 1000;
                if (mSales >= 25000)
                    mBonus = 2000;
            }
            else            
                mBonus = 0;

            Console.WriteLine(mBonus);
        }
    }
}
