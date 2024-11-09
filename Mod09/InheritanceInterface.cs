using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prim_inh02
{
    interface IMoving
    {
        public void Step();
    }
    abstract class Shape
    {
        protected Shape(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }
        public override string ToString() => $"Фигура: {PetName}";
        // A single virtual method.
        public virtual void Info()
        {
            Console.WriteLine($"Фигура '{this}'");
        }
        //public abstract void Step(); перенесен в интерфейс
    }
    class DemoPoint : Shape, IMoving
    {
        protected int x; // можно сделать приватным
        protected int y;
        public void StepX() => x+=1;
        public void StepY() => y += 1;
        public virtual void Step() // метод интерфейса нужно! реализовать (виртуальный, потому что в наследниках предполагается переопределение
        {
            StepX();
            StepY();
        }
        public override void Info()
        {
            Console.WriteLine("Отображение точки:");
            base.Info();
        }
        public DemoPoint(string name, int x, int y) : base(name)
        {
            this.x = x; 
            this.y = y;
        }
        public override string ToString() => $"Точка {PetName} на плоскости: {x}-{y}";
     }
    class Demo3DPoint : DemoPoint
    {
        protected int z;

        public override string ToString() => $"Точка {PetName} в пространстве: {x}-{y}-{z}";
               
        public Demo3DPoint(string name, int x, int y, int z) : base(name, x, y)
        {
            this.z = z;
        }
        public void StepZ() => z += 1;
        public override void Step() // переопределение базового поведения
        {
            base.StepX();
            base.StepY();
            StepZ();
        }
        public override void Info()
        {
            base.Info();
        }
    }
    class DemoLine : Shape, IMoving
    {
        protected DemoPoint p1;
        protected DemoPoint p2;
        public override string ToString() => $"Отрезок {PetName} на плоскости: ({p1}):({p2})"; 
        public DemoLine(DemoPoint p1, DemoPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Step() // своя реализация
        {
            p1.Step();
            p2.Step();
        }
        public override void Info()
        {
            base.Info();
        }
    }

    class Program
    {
        static void Main()
        {
            DemoPoint point1 = new DemoPoint("Первая", 2, 3);
            Console.WriteLine(point1);

            DemoPoint point2 = new DemoPoint("Вторая", 12, 14);
            Console.WriteLine(point2);
           
            point1.StepX();
            
            Demo3DPoint point3D = new Demo3DPoint("3D_Один", 10, 100, 1000);
            point3D.StepX();
            point3D.Step();
            Console.WriteLine(point3D.ToString());
            
            DemoLine line = new DemoLine(point1, point2);
            Console.WriteLine(line);
            line.Step();
            line.Info();

            DemoPoint[] pointT = { 
                new Demo3DPoint("3D_Поли", 12, 13, 14),
                new DemoPoint("Поли", 55,66)
            };
            foreach (var item in pointT) // тестирование полиморфизма
            {
                item.Step();
                item.Info();
            }
        }
    }

}
