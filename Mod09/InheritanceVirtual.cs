using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prim_inh02
{
    class DemoPoint
    {
        protected int x; // можно сделать приватным
        protected int y;
        public void StepX() => x+=1;
        public void StepY() => y += 1;
        public virtual void Step() // виртуальный метод можно переопределить
        {
            StepX();
            StepY();
        }
        public DemoPoint(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }
        public override string ToString() => $"Точка на плоскости: {x}-{y}";
     }
    class Demo3DPoint : DemoPoint
    {
        protected int z;

        public override string ToString() => $"Точка в пространстве: {x}-{y}-{z}";
               
        public Demo3DPoint(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public void StepZ() => z += 1;
        public override void Step()
        {
            base.StepX();
            base.StepY();
            StepZ();
        }
    }
    class DemoLine
    {
        protected DemoPoint p1;
        protected DemoPoint p2;
        public override string ToString() => $"Отрезок на плоскости: ({p1}):({p2})"; 
        public DemoLine(DemoPoint p1, DemoPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Step()
        {
            p1.Step();
            p2.Step();
        }
    }

    class Program
    {
        static void Main()
        {
            DemoPoint point1 = new DemoPoint(2, 3);
            Console.WriteLine(point1);

            DemoPoint point2 = new DemoPoint(12, 14);
            Console.WriteLine(point2);
           
            point1.StepX();
            
            Demo3DPoint point3D = new Demo3DPoint(10, 100, 1000);
            point3D.StepX();
            point3D.Step();
            Console.WriteLine(point3D.ToString());

            DemoLine line = new DemoLine(point1, point2);
            line.Step();

            Console.WriteLine(line);

            DemoPoint[] pointT = { 
                new Demo3DPoint(12, 13, 14),
                new DemoPoint(55,66)
            };
            foreach (var item in pointT) // тестирование полиморфизма
            {
                item.Step();
                Console.WriteLine(item);
            }
        }
    }

}
