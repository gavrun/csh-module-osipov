using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circle
{
        public int x=0;
        public int y=0;
        public int radius=3;
        public const double pi = 3.14;
        public static string name = "Окружность";
        
        public Circle T() //метод возвращает ссылку на экземпляр класса
        {
            return this;
        }
        
        public void Set(int x, int y, int r) 
        {
            this.x = x;
            this.y = y;
            radius=r;
        }
}

class Classthis
{
    static void Main()
    {
        Circle cr = new Circle();   //создание экземпляра класса
        Console.WriteLine("pi=" + Circle.pi);// обращение к константе
        Console.Write(Circle.name);// обращение к статическому полю
  //обращение к обычным полям
        Console.WriteLine(" с центром в точке ({0},{1}) и радиусом {2}", cr.x, cr.y, cr.radius);    
        cr.Set(1, 1, 10);
        Console.WriteLine("Новая окружность с центром в точке ({0},{1}) и радиусом {2}", 
        cr.x, cr.y, cr.radius);
        Circle b=cr.T();//получаем ссылку на объект cr, аналог b=c
        Console.WriteLine("Новая ссылка на окружность с центром в точке ({0},{1}) и радиусом {2}", b.x, b.y, b.radius);
  }
}

}
