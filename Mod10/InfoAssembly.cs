using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvfoAssembly
{
    class ProgAssembly
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";
            // Загрузить заданную сборку
            Assembly a = Assembly.LoadFile(path);
            Assembly theAssembly = Assembly.LoadFrom(path);
            ShowAssemblylnfo(a);
            ShowAssemblyMemders(theAssembly);

            // Получить сборку текущую сборку
            Assembly ourAssembly = Assembly.GetExecutingAssembly(); 
            ShowAssemblylnfo(ourAssembly);
            ShowAssemblyMemders(ourAssembly);
        }
        static void ShowAssemblylnfo(Assembly a) 
        {
            Console.WriteLine(a.FullName);
            Console.WriteLine("Path: {0}", a.Location);
            Console.WriteLine("Version: {0}", a.ImageRuntimeVersion);

            // Вывести модули
            foreach (Module m in a.GetModules()) 
            {
                Console.WriteLine("Mod: {0}", m.Name);
            }
        }

        static void ShowAssemblyMemders(Assembly a)
        {
            // Получить экземпляры и объявленные члены с помощью BindingFlags 
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Type[] types = a.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine("Type: {0}", t.Name);
                MemberInfo[] members = t.GetMembers(flags);
                foreach (MemberInfo member in members)
                {
                    Console.WriteLine("{0}: {1}", member.MemberType, member.Name);
                }
            }
        }
     }
 }


namespace Prim_inh02
{
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
        public abstract void Step();
    }
    class DemoPoint : Shape
    {
        protected int x; // можно сделать приватным
        protected int y;
        public void StepX() => x += 1;
        public void StepY() => y += 1;
        public override void Step() // абстрактный метод нужно! переопределить
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
        public override void Step()
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
    class DemoLine : Shape
    {
        protected DemoPoint p1;
        protected DemoPoint p2;
        public override string ToString() => $"Отрезок {PetName} на плоскости: ({p1}):({p2})";
        public DemoLine(DemoPoint p1, DemoPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public override void Step()
        {
            p1.Step();
            p2.Step();
        }
        public override void Info()
        {
            base.Info();
        }
    }
}


