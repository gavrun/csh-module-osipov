using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Gamer
    {
        private string Name;
        private Random r;

        public Gamer(string name)
        {
            Name = name;
            r = new Random();
        }

        public int SeansGame()
        {
          	//Случаное число от 1 до 6.
			      int res = r.Next(6)+1;
            return res;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    
    public class Program
	  {
	    public static void Main(string[] args)
	    {
	      Gamer g1 = new Gamer("Niko");
	      int hits = g1.SeansGame();
	      Console.WriteLine($"Для игрока {g1} выпало количество очков {hits}");
		  }
	  }
}