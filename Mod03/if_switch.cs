using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 8;
            string res = ExeSwitch(SetStatus(age));
            Console.WriteLine(res);
        }

        public static string SetStatus(int age)
        {
            string status = "junior developer";

            //if ((age > 2) && (age < 7)) status = "middle developer";
            //else if ((age >= 7) && (age < 15)) status = "senior developer";
            //else if ((age >= 15)) status = "sensei";


            if (age > 2) status = "middle developer";
            if (age >= 7) status = "senior developer";
            if (age >= 15) status = "sensei";

            return status;
        }


        public static string ExeSwitch(string status)
        {
            string res;
            switch (status)
            {
                case "junior developer":
                    res = "Набирайся знаний"; break;
                case "middle developer":
                    res = "Набирайся опыта"; break;
                case "senior developer":
                    res = "Руководи другими"; break;
                case "sensei":
                    res = "Учи других"; break;
                default:
                    res = "Не знаю, что делать";
                    break;
            }
            return res;
        }
    }
}
