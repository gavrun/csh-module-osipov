using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Radio
{
    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on: {0}", turnOn);
        }
    }

    class Car
    {
        // Car 'has' Radio
        private Radio myRadio = new Radio();

        public void TurnOnRadio(bool onOff)
        {
            // Делегированный вызов внутреннего объекта
            myRadio.Power(onOff);
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                // Вызов передается Radio 
                Car viper = new Car();
                viper.TurnOnRadio(false);

            }
        }
    
}
