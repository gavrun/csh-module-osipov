using System;

namespace ClasswithEvent
{

	// Создаем класс "Игральная кость".
	class Dice
	{
		Random r;
       
		//В конструкторе класса объявляем переменную r, генерируемую встроеным объектом Random
		public Dice()
		{
			r=new Random();
		}

		//Создаем метод, в котором будет реализовываться бросок.
		public int random()
		{
			//Случаное число от 1 до 6.
			int res = r.Next(6)+1;
			return res;
		}
	}

    class Gamer
    {
        string Name;
        Dice seans; // ассоциация - агрегация

        public Gamer(string name/*, Dice si*/)//для агрегации надо снять коммент
        {
            Name = name;
           // seans = si;// для агрегации
            seans = new Dice(); // для ссылки на  объект при композиции
        }

        public int SeansGame()
        {
            return seans.random();
        }

        //public int SeansGame(Dice ig) // зависимость
        //{
           
        //    return ig.random();
        //}

        public override string ToString()
        {
            return Name;
        }
    }


	class Program
	{
		static void Main(string[] args)
		{		
		
	    //Создаем экземпляр brosok класса 
            Dice roll = new Dice(); // для агрегации

          
         //   Gamer g1 = new Gamer("Niko",roll); // для агрегации
            Gamer g1 = new Gamer("Niko");           // для композиции
            for (int i = 1; i <= 6; i++)
            Console.WriteLine("Выпало количество очков {0} для игрока {1}", g1.SeansGame(), g1.ToString());
          //for (int  i = 1; i<=5; i++)
          //  Console.WriteLine("Выпало количество очков {0} для игрока {1}", g1.SeansGame(brosok), g1.ToString());

		}
	}
}
